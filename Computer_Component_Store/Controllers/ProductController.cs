using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Data;
using Computer_Component_Store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Computer_Component_Store.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        private void PopulateEmptyProducts()
        {
            if(_context.ComputerComponentProducts.Count() == 0)
            {
                _context.ComputerComponentProducts.AddRange(new ComputerComponentProduct
                {
                    ImageURL = "~/images/motherboard_1.jpg",
                    Name = "Motherboard",
                    Description = "wow great motherboard! XD",
                    Price = 1.99m
                    

                }, new ComputerComponentProduct
                {
                    ImageURL = "~/images/video_card_1.jpg",
                    Name = "ComputerComponent",
                    Description = "wow great ComputerComponent",
                    Price = 2.99m

                });
                _context.SaveChanges();
            }

            if (_context.Roles.Count() == 0)
            {
                _context.Roles.Add(new IdentityRole("Administrator"));
                _context.SaveChanges();
            }

            if ((_context.UserRoles.Count() == 0) && (_context.Users.Count() > 0))
            {
                _context.UserRoles.Add(
                    new IdentityUserRole<string>
                    {
                        RoleId = _context.Roles.Single(x => x.Name == "Administrator").Id,
                        UserId = _context.Users.First().Id
                    });
                _context.SaveChanges();
            }
        }

        public IActionResult Index(int? id)
        {
            PopulateEmptyProducts();

            ComputerComponentProduct product = _context.ComputerComponentProducts.Find(id);

            if (product != null)
            {

                ProductViewModel model = new ProductViewModel
                {
                    Name = product.Name,
                    ID = product.ID,
                    Description = product.Description,
                    Price = product.Price ?? 0m,
                    ImagePath = product.ImageURL,
                    Category = product.Category,
                    CompatibilityType = product.CompatibilityType,
                    ComputerComponentProducts = _context.ComputerComponentProducts.Where(x => x.CompatibilityType == product.CompatibilityType && x.ID != product.ID).ToArray()
                    
                };
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Index(int id, int quantity)
        {
            ComputerComponentCart computerComponentCart = null;
            if (User.Identity.IsAuthenticated)
            {
                var currentComputerUser = _context.Users.Include(x => x.ComputerComponentCart).ThenInclude(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).First(x => x.UserName == User.Identity.Name);
                if (currentComputerUser.ComputerComponentCart != null)
                {
                    computerComponentCart = currentComputerUser.ComputerComponentCart;
                }
                else
                {
                    computerComponentCart = new ComputerComponentCart
                    {
                        CookieID = Guid.NewGuid(),
                        Created = DateTime.UtcNow
                    };
                    currentComputerUser.ComputerComponentCart = computerComponentCart;
                    _context.SaveChanges();
                }
            }


            if ((computerComponentCart == null) && (Request.Cookies.ContainsKey("ComputerComponentCartID")))
            {
                if (Guid.TryParse(Request.Cookies["ComputerComponentCartID"], out Guid cookieId))
                {
                    computerComponentCart = _context.ComputerComponentCarts.Include(x => x.ComputerComponentCartItems).ThenInclude(x => x.ComputerComponentProduct).FirstOrDefault(x => x.CookieID == cookieId);
                }
            }

            if (computerComponentCart == null) // either couldnt find the cart for the cookie or the user had no cookie
            {
                computerComponentCart = new ComputerComponentCart
                {
                    CookieID = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                };
                _context.ComputerComponentCarts.Add(computerComponentCart);
            }
            computerComponentCart.LastModified = DateTime.UtcNow;

            ComputerComponentCartItem computerComponentCartItem = null;
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == id);

            if (computerComponentCartItem == null) //if still null, this is the first time this item has been added to the cart
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 0,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(id),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem.Quantity += quantity;
            computerComponentCartItem.LastModified = DateTime.UtcNow;
            _context.SaveChanges();


            if (!User.Identity.IsAuthenticated)
            {
                Response.Cookies.Append("ComputerComponentCartID", computerComponentCart.CookieID.Value.ToString());
            }
            return RedirectToAction("Index", "Cart");
        }
        public IActionResult Products()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult AllProducts()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Motherboards()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Processors()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult VideoCards()
        {
            return View(_context.ComputerComponentProducts);
        }

        public IActionResult RAM()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Storage()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult CoolingSystems()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Peripherals()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Cables()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Partpicker()
        {
            return View(_context.ComputerComponentProducts);
        }
    }
}
 