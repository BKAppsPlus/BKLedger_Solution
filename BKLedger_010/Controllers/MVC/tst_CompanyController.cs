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
    public class tst_CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public tst_CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: tst_Company
        public async Task<IActionResult> Index()
        {
            return View(await _context.tst_Company.ToListAsync());
        }

        // GET: tst_Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_Company = await _context.tst_Company
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tst_Company == null)
            {
                return NotFound();
            }

            return View(tst_Company);
        }

        // GET: tst_Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tst_Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] tst_Company tst_Company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tst_Company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tst_Company);
        }

        // GET: tst_Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_Company = await _context.tst_Company.FindAsync(id);
            if (tst_Company == null)
            {
                return NotFound();
            }
            return View(tst_Company);
        }

        // POST: tst_Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] tst_Company tst_Company)
        {
            if (id != tst_Company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tst_Company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tst_CompanyExists(tst_Company.Id))
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
            return View(tst_Company);
        }

        // GET: tst_Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_Company = await _context.tst_Company
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tst_Company == null)
            {
                return NotFound();
            }

            return View(tst_Company);
        }

        // POST: tst_Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tst_Company = await _context.tst_Company.FindAsync(id);
            _context.tst_Company.Remove(tst_Company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tst_CompanyExists(int id)
        {
            return _context.tst_Company.Any(e => e.Id == id);
        }
    }
}
