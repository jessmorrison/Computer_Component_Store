using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Models;
using Computer_Component_Store.Data;
using Microsoft.EntityFrameworkCore;

namespace Computer_Component_Store.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;

        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CheckoutViewModel model = new CheckoutViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var user = _context.Users
                    .FirstOrDefault(
                    x => x.UserName == User.Identity.Name);
                model.ContactEmail = user.Email;
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Do some more advanced validation 
                //  - the address info is required, but is it real? I can use an API to find out!
                //  - the credit card is required, but does it have available funds?  Again, I can use an API

                ComputerComponentCart computerComponentCart = null;
                if (User.Identity.IsAuthenticated)
                {
                    var currentComputerUser = _context.Users.Include(x => x.ComputerComponentCart).ThenInclude(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).First(x => x.UserName == User.Identity.Name);
                    if (currentComputerUser.ComputerComponentCart != null)
                    {
                        computerComponentCart = currentComputerUser.ComputerComponentCart;
                    }
                }
                else if (Request.Cookies.ContainsKey("ComputerComponentCartID"))
                {
                    if (Guid.TryParse(Request.Cookies["ComputerComponentCartID"], out Guid cookieId))
                    {
                        computerComponentCart = _context.ComputerComponentCarts.Include(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).FirstOrDefault(x => x.CookieID == cookieId);
                    }
                }
                if (computerComponentCart == null)
                {
                    ModelState.AddModelError("Cart", "There was a problem with your cart, please check your cart to verify that all items are correct");
                }
                else
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

                    _context.ComputerComponentOrders.Add(order);
                    // Delete the cart, cart items, and clear the cookie or "user cart" info so that the user will get a new cart next time.
                    _context.ComputerComponentCarts.Remove(computerComponentCart);

                    if (User.Identity.IsAuthenticated)
                    {
                        var currentComputerUser = _context.Users.Include(x => x.ComputerComponentCart).ThenInclude(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).First(x => x.UserName == User.Identity.Name);
                        currentComputerUser.ComputerComponentCart = null;
                    }
                    Response.Cookies.Delete("ComputerComponentCartID");

                    _context.SaveChanges();


                    // TODO: Email the user to let them know their order has been placed. -- I need an API for this!

                    // Redirect to the receipt page
                    return RedirectToAction("Index", "Receipt", new { order.ID });
                }
            }

            return View(model);
        }
    }
}