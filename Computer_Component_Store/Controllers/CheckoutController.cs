using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Models;
using Computer_Component_Store.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using Braintree;

namespace Computer_Component_Store.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;
        private IEmailSender _emailSender;
        private readonly IBraintreeGateway _braintreeGateway;

        public CheckoutController(ApplicationDbContext context, IEmailSender emailSender, IBraintreeGateway braintreeGateway)
        {
            _context = context;
            _emailSender = emailSender;
            _braintreeGateway = braintreeGateway;
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
            }

            this.ViewData["ClientToken"] = await _braintreeGateway.ClientToken.GenerateAsync();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CheckoutViewModel model, string payment_method_nonce)
        {
            if (ModelState.IsValid)
            {
              

                ComputerComponentCart computerComponentCart = null;
                if (User.Identity.IsAuthenticated)
                {
                    var currentComputerUser = await _context.Users.Include(x => x.ComputerComponentCart).ThenInclude(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).FirstAsync(x => x.UserName == User.Identity.Name);
                    if (currentComputerUser.ComputerComponentCart != null)
                    {
                        computerComponentCart = currentComputerUser.ComputerComponentCart;
                    }
                }
                else if (Request.Cookies.ContainsKey("ComputerComponentCartID"))
                {
                    if (Guid.TryParse(Request.Cookies["ComputerComponentCartID"], out Guid cookieId))
                    {
                        computerComponentCart = await _context.ComputerComponentCarts.Include(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).FirstOrDefaultAsync(x => x.CookieID == cookieId);
                    }
                }
                if (computerComponentCart == null)
                {
                    ModelState.AddModelError("Cart", "There was a problem with your cart, please check your cart to verify that all items are correct");
                }
                else
                {

                    // TODO: Do some more advanced validation 
                    //  - the address info is required, but is it real? I can use an API to find out!
                    //  - the credit card is required, but does it have available funds?  Again, I can use an API

                    TransactionRequest braintreeTranscation = new TransactionRequest
                    {
                        Amount = computerComponentCart.ComputerComponentCartItems.Sum(x => x.Quantity * (x.ComputerComponentProduct.Price ?? 0)),
                        PaymentMethodNonce = payment_method_nonce
                        //CreditCard = new TransactionCreditCardRequest
                        //{
                        //    CardholderName = "Test User",
                        //    CVV = "123",
                        //    ExpirationMonth = DateTime.Now.Month.ToString().PadLeft(2, '0'),
                        //    ExpirationYear = DateTime.Now.AddYears(1).Year.ToString(),
                        //    Number = "4111111111111111"

                        //}
                    };

                    var transactionResult = await _braintreeGateway.Transaction.SaleAsync(braintreeTranscation);
                    if (transactionResult.IsSuccess())
                    {

                        // Take the existing cart, and convert the cart and cart items to an  "order" with "order items"
                        //  - when creating order items, I'm going to "denormalize" the info to copy the price, description, etc. of what the customer ordered.
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
                            var currentComputerUser = await _context.Users.Include(x => x.ComputerComponentCart).ThenInclude(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).FirstAsync(x => x.UserName == User.Identity.Name);
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
                        foreach (var transactionError in transactionResult.Errors.All())
                        {
                            this.ModelState.AddModelError(transactionError.Code.ToString(), transactionError.Message);
                        }
                    }
                }
            }
            return View(model);
        }
    }
}