using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Computer_Component_Store.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Computer_Component_Store.Controllers
{
    public class ReceiptController : Controller
    {
        private ApplicationDbContext _context;
        public ReceiptController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(Guid id)
        {
            return View(_context.ComputerComponentOrders.Include(x => x.ComputerComponentOrderItems).Single(x => x.ID == id));
        }
    }
}