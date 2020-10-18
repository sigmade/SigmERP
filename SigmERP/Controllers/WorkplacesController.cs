using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SigmERP.Models;

namespace SigmERP.Controllers
{
    public class WorkplacesController : Controller
    {
        private readonly ApplicationContext _context;

        public WorkplacesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Workplaces
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workplaces.ToListAsync());
        }

        // GET: Workplaces/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplaces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workplace == null)
            {
                return NotFound();
            }

            return View(workplace);
        }

        // GET: Workplaces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workplaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Workplace workplace)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workplace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workplace);
        }

        // GET: Workplaces/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplaces.FindAsync(id);
            if (workplace == null)
            {
                return NotFound();
            }
            return View(workplace);
        }

        // POST: Workplaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name")] Workplace workplace)
        {
            if (id != workplace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workplace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkplaceExists(workplace.Id))
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
            return View(workplace);
        }

        // GET: Workplaces/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplaces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workplace == null)
            {
                return NotFound();
            }

            return View(workplace);
        }

        // POST: Workplaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var workplace = await _context.Workplaces.FindAsync(id);
            _context.Workplaces.Remove(workplace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkplaceExists(string id)
        {
            return _context.Workplaces.Any(e => e.Id == id);
        }
    }
}
