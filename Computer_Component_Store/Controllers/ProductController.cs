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
                    ImageURL = "~/images/motherboard_1.png",
                    Name = "Motherboard",
                    Description = "wow great motherboard! XD",
                    Price = 1.99m
                    

                }, new ComputerComponentProduct
                {
                    ImageURL = "~/images/video_card_1.png",
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
        public IActionResult Index
            (
            int id, 
            int quantity,
            /*Hardcore View Values*/
            int? CaseIDHardcore,
            int? MotherboardIDHardcore,
            int? VideoCardIDHardcore,
            int? ProcessorIDHardcore,
            int? RAMIDHardcore,
            int? StorageIDHardcore,
            int? CoolingSystemIDHardcore,
            /*Casual View Values*/
            int? CaseIDCasual,
            int? MotherboardIDCasual,
            int? VideoCardIDCasual,
            int? ProcessorIDCasual,
            int? RAMIDCasual,
            int? StorageIDCasual,
            int? CoolingSystemIDCasual,
            /*Pleb View Values*/
            int? CaseIDPleb,
            int? MotherboardIDPleb,
            int? VideoCardIDPleb,
            int? ProcessorIDPleb,
            int? RAMIDPleb,
            int? StorageIDPleb,
            int? CoolingSystemIDPleb
            )
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
            /* START Individual Item Add To Cart */
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == id);

            if (computerComponentCartItem != null)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                
            }
            if (
                computerComponentCartItem == null &&
                !CaseIDHardcore.HasValue &&
                !MotherboardIDHardcore.HasValue &&
                !VideoCardIDHardcore.HasValue &&
                !ProcessorIDHardcore.HasValue &&
                !RAMIDHardcore.HasValue &&
                !StorageIDHardcore.HasValue &&
                !CoolingSystemIDHardcore.HasValue 
                || 
                computerComponentCartItem == null &&
                !CaseIDCasual.HasValue &&
                !MotherboardIDCasual.HasValue &&
                !VideoCardIDCasual.HasValue &&
                !ProcessorIDCasual.HasValue &&
                !RAMIDCasual.HasValue &&
                !StorageIDCasual.HasValue &&
                !CoolingSystemIDCasual.HasValue
                ||
                computerComponentCartItem == null &&
                !CaseIDPleb.HasValue &&
                !MotherboardIDPleb.HasValue &&
                !VideoCardIDPleb.HasValue &&
                !ProcessorIDPleb.HasValue &&
                !RAMIDPleb.HasValue &&
                !StorageIDPleb.HasValue &&
                !CoolingSystemIDPleb.HasValue
                )
            {
                if (id > 0)
                {
                    computerComponentCartItem = new ComputerComponentCartItem
                    {
                        Quantity = 1,
                        ComputerComponentProduct = _context.ComputerComponentProducts.Find(id),
                        Created = DateTime.UtcNow,
                    };
                    computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
                }
            }
            /* END Individual Item Add To Cart */
            /* START Hardcore Part Picker Add To Cart */
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CaseIDHardcore);
            if (computerComponentCartItem != null && CaseIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;

            }
            if (computerComponentCartItem == null && CaseIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CaseIDHardcore.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == MotherboardIDHardcore);
            if (computerComponentCartItem != null && MotherboardIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;

            }
            if (computerComponentCartItem == null && MotherboardIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(MotherboardIDHardcore.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == VideoCardIDHardcore);
            if (computerComponentCartItem != null && VideoCardIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && VideoCardIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(VideoCardIDHardcore.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == ProcessorIDHardcore);
            if (computerComponentCartItem != null && ProcessorIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && ProcessorIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(ProcessorIDHardcore.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == RAMIDHardcore);
            if (computerComponentCartItem != null && RAMIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                RAMIDHardcore = null;
            }
            if (computerComponentCartItem == null && RAMIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(RAMIDHardcore.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == StorageIDHardcore);
            if (computerComponentCartItem != null && StorageIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                StorageIDHardcore = null;
            }
            if (computerComponentCartItem == null && StorageIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(StorageIDHardcore.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CoolingSystemIDHardcore);
            if (computerComponentCartItem != null && CoolingSystemIDHardcore.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                CoolingSystemIDHardcore = null;
            }
            if (computerComponentCartItem == null && CoolingSystemIDHardcore.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CoolingSystemIDHardcore.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            /* END HARDCORE Part Picker Add To Cart */
            /* START CASUAL Part Picker Add To Cart */
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CaseIDCasual);
            if (computerComponentCartItem != null && CaseIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && CaseIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CaseIDCasual.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == MotherboardIDCasual);
            if (computerComponentCartItem != null && MotherboardIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && MotherboardIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(MotherboardIDCasual.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == VideoCardIDCasual);
            if (computerComponentCartItem != null && VideoCardIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && VideoCardIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(VideoCardIDCasual.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == ProcessorIDCasual);
            if (computerComponentCartItem != null && ProcessorIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && ProcessorIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(ProcessorIDCasual.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == RAMIDCasual);
            if (computerComponentCartItem != null && RAMIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                RAMIDCasual = null;
            }
            if (computerComponentCartItem == null && RAMIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(RAMIDCasual.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == StorageIDCasual);
            if (computerComponentCartItem != null && StorageIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                StorageIDCasual = null;
            }
            if (computerComponentCartItem == null && StorageIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(StorageIDCasual.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CoolingSystemIDCasual);
            if (computerComponentCartItem != null && CoolingSystemIDCasual.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                CoolingSystemIDCasual = null;
            }
            if (computerComponentCartItem == null && CoolingSystemIDCasual.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CoolingSystemIDCasual.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }

            /* END CASUAL Part Picker Add To Cart */
            /* PLEB Part Picker Add To Cart */
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CaseIDPleb);
            if (computerComponentCartItem != null && CaseIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;

            }
            if (computerComponentCartItem == null && CaseIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CaseIDPleb.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == MotherboardIDPleb);
            if (computerComponentCartItem != null && MotherboardIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;

            }
            if (computerComponentCartItem == null && MotherboardIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(MotherboardIDPleb.Value),
                    Created = DateTime.UtcNow
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == VideoCardIDPleb);
            if (computerComponentCartItem != null && VideoCardIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && VideoCardIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(VideoCardIDPleb.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == ProcessorIDPleb);
            if (computerComponentCartItem != null && ProcessorIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
            }
            if (computerComponentCartItem == null && ProcessorIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(ProcessorIDPleb.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == RAMIDPleb);
            if (computerComponentCartItem != null && RAMIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                RAMIDPleb = null;
            }
            if (computerComponentCartItem == null && RAMIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(RAMIDPleb.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == StorageIDPleb);
            if (computerComponentCartItem != null && StorageIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                StorageIDPleb = null;
            }
            if (computerComponentCartItem == null && StorageIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(StorageIDPleb.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            computerComponentCartItem = computerComponentCart.ComputerComponentCartItems.FirstOrDefault(x => x.ComputerComponentProduct.ID == CoolingSystemIDPleb);
            if (computerComponentCartItem != null && CoolingSystemIDPleb.HasValue)
            {
                computerComponentCartItem.Quantity += quantity;
                computerComponentCartItem.LastModified = DateTime.UtcNow;
                CoolingSystemIDPleb = null;
            }
            if (computerComponentCartItem == null && CoolingSystemIDPleb.HasValue)
            {
                computerComponentCartItem = new ComputerComponentCartItem
                {
                    Quantity = 1,
                    ComputerComponentProduct = _context.ComputerComponentProducts.Find(CoolingSystemIDPleb.Value),
                    Created = DateTime.UtcNow,
                };
                computerComponentCart.ComputerComponentCartItems.Add(computerComponentCartItem);
            }
            /*PLEB End Part Picker Add To Cart */


            _context.SaveChanges();


            if (!User.Identity.IsAuthenticated)
            {
                Response.Cookies.Append("ComputerComponentCartID", computerComponentCart.CookieID.Value.ToString());
            }
            return RedirectToAction("Index", "Cart");
        }

        public void PlebPartPicker()
        {

        }

        public IActionResult Home()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult AllProducts()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult Cases()
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
        public IActionResult HardcoreFeaturedBuild()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult CasualFeaturedBuild()
        {
            return View(_context.ComputerComponentProducts);
        }
        public IActionResult PlebFeaturedBuild()
        {
            return View(_context.ComputerComponentProducts);
        }
    }
}
 