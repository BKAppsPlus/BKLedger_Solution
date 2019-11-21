using System;
using System.Collections.Generic;
using System.Text;
using BKLedger_010.Models.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BKLedger_020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Core_Transaction> Core_Transactions { get; set; }
        public DbSet<Core_Ledger> Core_Ledgers { get; set; }
        //public DbSet<Core_LedgerMembership> Core_LedgerMemberships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Core_LedgerMembership>()
                .HasKey(lm => new { lm.LedgerMemberId, lm.LedgerId });
            builder.Entity<Core_LedgerMembership>()
                .HasOne(lm => lm.LedgerMember)
                .WithMany(m => m.AssignedLedgers)
                .HasForeignKey(e => e.LedgerMemberId);
            builder.Entity<Core_LedgerMembership>()
                .HasOne(lm => lm.Ledger)
                .WithMany(l => l.LedgerMembers)
                .HasForeignKey(e => e.LedgerId);
            base.OnModelCreating(builder);
        }
    }
}
