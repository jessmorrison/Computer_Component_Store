using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    Name = "Green Soda",
                    Description = "wow great sodaa",
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



        /*
         * 
         * using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SodaStore.Data;
using SodaStore.Models;

namespace SodaStore.Controllers
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
            if(_context.SodaProducts.Count() == 0)
            {
                _context.SodaProducts.AddRange(new SodaProduct
                {
                    ImageURL = "~/images/exotic_soda.jpg",
                    Name = "Exotic Sode",
                    Description = "wow great soda",
                    Price = 1.99m

                }, new SodaProduct
                {
                    ImageURL = "~/images/green_cream.jpg",
                    Name = "Green Soda",
                    Description = "wow great sodaa",
                    Price = 2.99m

                });
                _context.SaveChanges();
            }
        }

        public IActionResult Index(int? id)
        {
            SodaProduct product = _context.SodaProducts.Find(id);

            if (product != null)
            {

                ProductViewModel model = new ProductViewModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price ?? 0m,
                    ImagePath = product.ImageURL,
                    ID = product.ID

                    //ImagePath = "~/images/exotic_soda.jpg"
                };
                return View(model);
            }
          

            return NotFound();
        }

        [HttpPost]
        public IActionResult Index(int id, int quantity)
        {
            SodaCart sodaCart = null;
            if (Request.Cookies.ContainsKey("SodaCartID"))
            {
                if (Guid.TryParse(Request.Cookies["SodaCartId"], out Guid cookieId))
                {
                    sodaCart = _context.SodaCarts.Include(x => x.SodaCartItems).ThenInclude(x => x.SodaProduct).FirstOrDefault(x => x.CookieID == cookieId);
                }
            }

            if (sodaCart == null) // either couldnt find the cart for the cookie or the user had no cookie
            {
                sodaCart = new SodaCart
                {
                    CookieID = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                };
                _context.SodaCarts.Add(sodaCart);
            }
            sodaCart.LastModified = DateTime.UtcNow;

            SodaCartItem sodaCartItem = null;
            sodaCartItem = sodaCart.SodaCartItems.FirstOrDefault(x => x.SodaProduct.ID == id);

            if (sodaCartItem == null) //if still null, this is the first time this item has been added to the cart
            {
                sodaCartItem = new SodaCartItem
                    { 
                        Quantity = 0,
                        SodaProduct = _context.SodaProducts.Find(id),
                        Created = DateTime.UtcNow,
                };
                sodaCart.SodaCartItems.Add(sodaCartItem);
            }
            sodaCartItem.Quantity += quantity;
            sodaCartItem.LastModified = DateTime.UtcNow;
            _context.SaveChanges();
            Response.Cookies.Append("SodaCartID", sodaCart.CookieID.Value.ToString());

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult List()
        {
            return View(_context.SodaProducts);
        }
    }
}
*/















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
 