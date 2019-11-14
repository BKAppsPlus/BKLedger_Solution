using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BKLedger_010.Models;

namespace BKLedger_010.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LedgerMember>()
                .HasKey(lm => new { lm.UserId, lm.LedgerId });
            builder.Entity<LedgerMember>()
                .HasOne(lm => lm.LedgerUser)
                .WithMany(lm => lm.LedgerMembers)
                .HasForeignKey(lm => lm.UserId);
            builder.Entity<LedgerMember>()
                .HasOne(lm => lm.Ledger)
                .WithMany(lm => lm.LedgerMembers)
                .HasForeignKey(lm => lm.LedgerId);


            base.OnModelCreating(builder);
        }

        public DbSet<BKLedger_010.Models.LedgerMember> LedgerMember { get; set; }

    }
}
