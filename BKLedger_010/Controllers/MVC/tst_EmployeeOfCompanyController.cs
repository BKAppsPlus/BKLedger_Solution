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
    public class tst_EmployeeOfCompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public tst_EmployeeOfCompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: tst_EmployeeOfCompany
        public async Task<IActionResult> Index()
        {
            return View(await _context.tst_EmployeeOfCompany.ToListAsync());
        }

        // GET: tst_EmployeeOfCompany/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_EmployeeOfCompany = await _context.tst_EmployeeOfCompany
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tst_EmployeeOfCompany == null)
            {
                return NotFound();
            }

            return View(tst_EmployeeOfCompany);
        }

        // GET: tst_EmployeeOfCompany/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tst_EmployeeOfCompany/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] tst_EmployeeOfCompany tst_EmployeeOfCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tst_EmployeeOfCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tst_EmployeeOfCompany);
        }

        // GET: tst_EmployeeOfCompany/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_EmployeeOfCompany = await _context.tst_EmployeeOfCompany.FindAsync(id);
            if (tst_EmployeeOfCompany == null)
            {
                return NotFound();
            }
            return View(tst_EmployeeOfCompany);
        }

        // POST: tst_EmployeeOfCompany/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] tst_EmployeeOfCompany tst_EmployeeOfCompany)
        {
            if (id != tst_EmployeeOfCompany.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tst_EmployeeOfCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tst_EmployeeOfCompanyExists(tst_EmployeeOfCompany.Id))
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
            return View(tst_EmployeeOfCompany);
        }

        // GET: tst_EmployeeOfCompany/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tst_EmployeeOfCompany = await _context.tst_EmployeeOfCompany
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tst_EmployeeOfCompany == null)
            {
                return NotFound();
            }

            return View(tst_EmployeeOfCompany);
        }

        // POST: tst_EmployeeOfCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tst_EmployeeOfCompany = await _context.tst_EmployeeOfCompany.FindAsync(id);
            _context.tst_EmployeeOfCompany.Remove(tst_EmployeeOfCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tst_EmployeeOfCompanyExists(int id)
        {
            return _context.tst_EmployeeOfCompany.Any(e => e.Id == id);
        }
    }
}
