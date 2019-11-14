using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BKLedger_010.Data;
using BKLedger_010.Models;

namespace BKLedger_010.Controllers.MVC
{
    public class LedgersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LedgersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ledgers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ledgers.ToListAsync());
        }

        // GET: Ledgers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledger = await _context.Ledgers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ledger == null)
            {
                return NotFound();
            }

            return View(ledger);
        }

        // GET: Ledgers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ledgers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IsActive,CreatedBy,Created,ModifiedBy,Modified")] Ledger ledger)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ledger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ledger);
        }

        // GET: Ledgers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledger = await _context.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }
            return View(ledger);
        }

        // POST: Ledgers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IsActive,CreatedBy,Created,ModifiedBy,Modified")] Ledger ledger)
        {
            if (id != ledger.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ledger);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LedgerExists(ledger.Id))
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
            return View(ledger);
        }

        // GET: Ledgers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledger = await _context.Ledgers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ledger == null)
            {
                return NotFound();
            }

            return View(ledger);
        }

        // POST: Ledgers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ledger = await _context.Ledgers.FindAsync(id);
            _context.Ledgers.Remove(ledger);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LedgerExists(int id)
        {
            return _context.Ledgers.Any(e => e.Id == id);
        }
    }
}
