using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Computer_Component_Store.Data;
using Microsoft.EntityFrameworkCore;

namespace Computer_Component_Store.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
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
            return View(computerComponentCart);
        }

        [HttpPost]
        public IActionResult Index(ComputerComponentCart model)
        {
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
            foreach (var item in computerComponentCart.ComputerComponentCartItems)
            {
                var modelItem = model.ComputerComponentCartItems.FirstOrDefault(x => x.ID == item.ID);
                if (modelItem != null && modelItem.Quantity != item.Quantity)
                {
                    item.LastModified = DateTime.UtcNow;
                    item.Quantity = modelItem.Quantity;
                    if (item.Quantity == 0)
                    {
                        _context.ComputerComponentCartItems.Remove(item);
                    }
                }
            }
            _context.SaveChanges();
            return View(computerComponentCart);
        }
    }
}