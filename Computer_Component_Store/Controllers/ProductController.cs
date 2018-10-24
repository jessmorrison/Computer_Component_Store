using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Data;
using Computer_Component_Store.Models;

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
                    ImageURL = "~/images/exotic_soda.jpg",
                    Name = "Exotic Sode",
                    Description = "wow great soda",
                    Price = 1.99m
                    

                }, new ComputerComponentProduct
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