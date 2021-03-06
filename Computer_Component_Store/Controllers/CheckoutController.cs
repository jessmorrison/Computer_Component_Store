﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Models;
using Computer_Component_Store.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using Braintree;
using SmartyStreets;
using SmartyStreets.USStreetApi;

namespace Computer_Component_Store.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;
        private IEmailSender _emailSender;
        private IBraintreeGateway _braintreeGateway;
        private IClient<Lookup> _streetClient;

        public CheckoutController(ApplicationDbContext context, IEmailSender emailSender, IBraintreeGateway braintreeGateway, IClient<Lookup> streetClient)
        {
            _context = context;
            _emailSender = emailSender;
            _braintreeGateway = braintreeGateway;
            _streetClient = streetClient;
        }
        public async Task<IActionResult> Index()
        {
            CheckoutViewModel model = new CheckoutViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var user = await _context.Users
                    .FirstOrDefaultAsync(
                    x => x.UserName == User.Identity.Name);
                model.ContactEmail = user.Email;
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                CustomerSearchRequest customerSearchRequest = new CustomerSearchRequest();
                customerSearchRequest.Email.Is(User.Identity.Name);
                var customers = await _braintreeGateway.Customer.SearchAsync(customerSearchRequest);
                if (customers.Ids.Any())
                {
                    Customer customer = customers.FirstItem;
                    model.CreditCards = customer.CreditCards;
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult ValidateAddress([FromBody]Lookup lookup)
        {
            try
            {
                _streetClient.Send(lookup);
                return Json(lookup.Result);
            }
            catch (SmartyException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {
                ComputerComponentCart computerComponentCart = null;
                if (User.Identity.IsAuthenticated)
                {
                    var currentComputerUser = await _context.Users
                        .Include(x => x.ComputerComponentCart)
                        .ThenInclude(x => x.ComputerComponentCartItems)
                        .ThenInclude(x => x.ComputerComponentProduct)
                        .FirstAsync(x => x.UserName == User.Identity.Name);

                    if (currentComputerUser.ComputerComponentCart != null)
                    {
                        computerComponentCart = currentComputerUser.ComputerComponentCart;
                    }
                }
                else if (Request.Cookies.ContainsKey("ComputerComponentCartID"))
                {
                    if (Guid.TryParse(Request.Cookies["ComputerComponentCartID"], out Guid cookieId))
                    {
                        computerComponentCart = await _context.ComputerComponentCarts
                            .Include(x => x.ComputerComponentCartItems)
                            .ThenInclude(x => x.ComputerComponentProduct)
                            .FirstOrDefaultAsync(x => x.CookieID == cookieId);
                    }
                }
                if (computerComponentCart == null)
                {
                    ModelState.AddModelError("Cart", "There was a problem with your cart, please check your cart to verify that all items are correct");
                }
                else
                {
                    if ((User.Identity.IsAuthenticated) && model.CreditCardSave)
                    {
                        //First, check if the customer exists
                        CustomerSearchRequest customerSearchRequest = new CustomerSearchRequest();
                        customerSearchRequest.Email.Is(User.Identity.Name);
                        Customer customer = null;
                        var customers = await _braintreeGateway.Customer.SearchAsync(customerSearchRequest);
                        if (customers.Ids.Any())
                        {
                            customer = customers.FirstItem;
                        }
                        else
                        {
                            CustomerRequest newCustomer = new CustomerRequest
                            {
                                Email = User.Identity.Name
                            };
                            var createResult = await _braintreeGateway.Customer.CreateAsync(newCustomer);
                            if (createResult.IsSuccess())
                            {
                                customer = createResult.Target;
                            }
                            else
                            {
                                throw new Exception(createResult.Message);
                            }
                        }
                        CreditCardRequest newPaymentMethod = new CreditCardRequest
                        {
                            CustomerId = customer.Id,
                            Number = model.CreditCardNumber,
                            CVV = model.CreditCardVerificationValue,
                            ExpirationMonth = (model.CreditCardExpirationMonth ?? 0).ToString().PadLeft(2, '0'),
                            ExpirationYear = (model.CreditCardExpirationYear ?? 0).ToString()
                        };
                        var createPaymentResult = await _braintreeGateway.CreditCard.CreateAsync(newPaymentMethod);
                        if (!createPaymentResult.IsSuccess())
                        {
                            throw new Exception(createPaymentResult.Message);
                        }
                        else
                        {
                            model.SavedCreditCardToken = createPaymentResult.Target.Token;
                        }
                    }
                    //Smarty Streets Address Lookup
                    Lookup lookup = new Lookup
                    {
                        Street = model.ShippingStreet,
                        City = model.ShippingCity,
                        State = model.ShippingState,
                        ZipCode = model.ShippingPostalCode
                    };
                    _streetClient.Send(lookup);
                    if (lookup.Result.Any())
                    {
                        TransactionRequest braintreeTransaction = new TransactionRequest
                        {
                            Amount = computerComponentCart.ComputerComponentCartItems.Sum(x => x.Quantity * (x.ComputerComponentProduct.Price ?? 0))
                        };
                        if (model.SavedCreditCardToken == null)
                        {
                            braintreeTransaction.CreditCard = new TransactionCreditCardRequest
                            {
                                CVV = model.CreditCardVerificationValue,
                                ExpirationMonth = (model.CreditCardExpirationMonth ?? 0).ToString().PadLeft(2, '0'),
                                ExpirationYear = (model.CreditCardExpirationYear ?? 0).ToString(),
                                Number = model.CreditCardNumber
                            };
                        }
                        else
                        {
                            braintreeTransaction.PaymentMethodToken = model.SavedCreditCardToken;
                        }
                        var transactionResult = await _braintreeGateway.Transaction.SaleAsync(braintreeTransaction);
                        if (transactionResult.IsSuccess())
                        {
                            ComputerComponentOrder order = new ComputerComponentOrder
                            {
                                ContactEmail = model.ContactEmail,
                                Created = DateTime.UtcNow,
                                FirstName = model.FirstName,
                                LastModified = DateTime.UtcNow,
                                LastName = model.LastName,
                                ShippingCity = model.ShippingCity,
                                ShippingPostalCode = model.ShippingPostalCode,
                                ShippingState = model.ShippingState,
                                ShippingStreet = model.ShippingStreet,
                                ComputerComponentOrderItems = computerComponentCart.ComputerComponentCartItems.Select(x => new ComputerComponentOrderItem
                                {
                                    Created = DateTime.UtcNow,
                                    LastModified = DateTime.UtcNow,
                                    ProductDescription = x.ComputerComponentProduct.Description,
                                    ProductID = x.ComputerComponentProduct.ID,
                                    ProductName = x.ComputerComponentProduct.Name,
                                    ProductPrice = x.ComputerComponentProduct.Price,
                                    Quantity = x.Quantity
                                }).ToHashSet()
                            };
                            await _context.ComputerComponentOrders.AddAsync(order);
                            // Delete the cart, cart items, and clear the cookie or "user cart" info so that the user will get a new cart next time.
                            _context.ComputerComponentCarts.Remove(computerComponentCart);

                            if (User.Identity.IsAuthenticated)
                            {
                                var currentComputerUser = await _context.Users
                                    .Include(x => x.ComputerComponentCart)
                                    .ThenInclude(x => x.ComputerComponentCartItems)
                                    .ThenInclude(x => x.ComputerComponentProduct)
                                    .FirstAsync(x => x.UserName == User.Identity.Name);

                                currentComputerUser.ComputerComponentCart = null;
                            }
                            Response.Cookies.Delete("ComputerComponentCartID");

                            await _context.SaveChangesAsync();

                            string subject = "Congratulations, order # " + order.ID + " has been placed";
                            UriBuilder builder = new UriBuilder(Request.Scheme, Request.Host.Host, Request.Host.Port ?? 80, "receipt/index/" + order.ID);
                            string htmlContent = string.Format("<a href=\"{0}\">Check out your order</a>", builder.ToString());
                            await _emailSender.SendEmailAsync(model.ContactEmail, subject, htmlContent);

                            // Redirect to the receipt page
                            return RedirectToAction("Index", "Receipt", new { order.ID });
                        }
                        else
                        {
                            this.ModelState.AddModelError("CreditCardNumber", transactionResult.Message);
                            foreach (var transactionError in transactionResult.Errors.All())
                            {
                                this.ModelState.AddModelError(transactionError.Code.ToString(), transactionError.Message);
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ShippingStreet", "Unable to validate this address. Please make sure you enter it correctly");
                    }
                }
            }
            return View(model);
        }
    }
}