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
    public class LedgerMembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LedgerMembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LedgerMembers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LedgerMember.Include(l => l.Ledger).Include(l => l.LedgerUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LedgerMembers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledgerMember = await _context.LedgerMember
                .Include(l => l.Ledger)
                .Include(l => l.LedgerUser)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (ledgerMember == null)
            {
                return NotFound();
            }

            return View(ledgerMember);
        }

        // GET: LedgerMembers/Create
        public IActionResult Create()
        {
            ViewData["LedgerId"] = new SelectList(_context.Ledgers, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: LedgerMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,LedgerId")] LedgerMember ledgerMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ledgerMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LedgerId"] = new SelectList(_context.Ledgers, "Id", "Id", ledgerMember.LedgerId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", ledgerMember.UserId);
            return View(ledgerMember);
        }

        // GET: LedgerMembers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledgerMember = await _context.LedgerMember.FindAsync(id);
            if (ledgerMember == null)
            {
                return NotFound();
            }
            ViewData["LedgerId"] = new SelectList(_context.Ledgers, "Id", "Id", ledgerMember.LedgerId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", ledgerMember.UserId);
            return View(ledgerMember);
        }

        // POST: LedgerMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,LedgerId")] LedgerMember ledgerMember)
        {
            if (id != ledgerMember.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ledgerMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LedgerMemberExists(ledgerMember.UserId))
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
            ViewData["LedgerId"] = new SelectList(_context.Ledgers, "Id", "Id", ledgerMember.LedgerId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", ledgerMember.UserId);
            return View(ledgerMember);
        }

        // GET: LedgerMembers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledgerMember = await _context.LedgerMember
                .Include(l => l.Ledger)
                .Include(l => l.LedgerUser)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (ledgerMember == null)
            {
                return NotFound();
            }

            return View(ledgerMember);
        }

        // POST: LedgerMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ledgerMember = await _context.LedgerMember.FindAsync(id);
            _context.LedgerMember.Remove(ledgerMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LedgerMemberExists(string id)
        {
            return _context.LedgerMember.Any(e => e.UserId == id);
        }
    }
}
