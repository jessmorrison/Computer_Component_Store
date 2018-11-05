using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Computer_Component_Store.Data;

namespace Computer_Component_Store.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class ComputerComponentProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComputerComponentProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComputerComponentProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComputerComponentProducts.ToListAsync());
        }

        // GET: ComputerComponentProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerComponentProduct = await _context.ComputerComponentProducts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (computerComponentProduct == null)
            {
                return NotFound();
            }

            return View(computerComponentProduct);
        }

        // GET: ComputerComponentProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComputerComponentProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,ImageURL,Price,Category,Created,LastModified")] ComputerComponentProduct computerComponentProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computerComponentProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computerComponentProduct);
        }

        // GET: ComputerComponentProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerComponentProduct = await _context.ComputerComponentProducts.FindAsync(id);
            if (computerComponentProduct == null)
            {
                return NotFound();
            }
            return View(computerComponentProduct);
        }

        // POST: ComputerComponentProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,ImageURL,Price,Category,Created,LastModified")] ComputerComponentProduct computerComponentProduct)
        {
            if (id != computerComponentProduct.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computerComponentProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputerComponentProductExists(computerComponentProduct.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(computerComponentProduct);
        }

        // GET: ComputerComponentProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerComponentProduct = await _context.ComputerComponentProducts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (computerComponentProduct == null)
            {
                return NotFound();
            }

            return View(computerComponentProduct);
        }

        // POST: ComputerComponentProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computerComponentProduct = await _context.ComputerComponentProducts.FindAsync(id);
            _context.ComputerComponentProducts.Remove(computerComponentProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputerComponentProductExists(int id)
        {
            return _context.ComputerComponentProducts.Any(e => e.ID == id);
        }
    }
}
