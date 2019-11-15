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

            builder.Entity<tst_Company>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Company)
                .IsRequired();
            //or:
            //builder.Entity<Employee>()
            //    .HasOne(e => e.Company)
            //    .WithMany(c => c.Employees);
            base.OnModelCreating(builder);
        }

        public DbSet<BKLedger_010.Models.LedgerMember> LedgerMember { get; set; }

        public DbSet<BKLedger_010.Models.tst_Company> tst_Company { get; set; }
        public DbSet<BKLedger_010.Models.tst_EmployeeOfCompany> tst_EmployeeOfCompany { get; set; }

    }
}
