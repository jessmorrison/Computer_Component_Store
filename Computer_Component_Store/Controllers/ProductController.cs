using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Data;
using Computer_Component_Store.Models;
using Microsoft.EntityFrameworkCore;

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
        }

        public IActionResult Index(int? id)
        {
            ComputerComponentProduct product = _context.ComputerComponentProducts.Find(id);

            if (product != null)
            {

                ProductViewModel model = new ProductViewModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price ?? 0m,
                    ImagePath = product.ImageURL,
                    Category = product.Category
                };
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Index(int id, int quantity)
        {
            ComputerComponentCart computerComponentCart = null;
            if (Request.Cookies.ContainsKey("ComputerComponentCartID"))
            {
                if (Guid.TryParse(Request.Cookies["ComputerComponentCartId"], out Guid cookieId))
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

            Response.Cookies.Append("ComputerComponentCartID", computerComponentCart.CookieID.Value.ToString());

            return RedirectToAction("Index", "Cart");
        }


       public IActionResult AllProducts()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Motherboards()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult VideoCards()
        {
            return View(_context.ComputerComponentProducts);
        }
    }
}
 