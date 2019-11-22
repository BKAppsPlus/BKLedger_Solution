using System;
using System.Collections.Generic;
using System.Text;
using BKLedger_010.Models.Core;
using Microsoft.AspNetCore.Identity;
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

            #region SeedingIdentity

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
                );

            Core_ApplicationUser appUser = new Core_ApplicationUser
            {
                UserName = "admin@BKLedgerApp.com",
                Email = "admin@BKLedgerApp.com",
                NormalizedEmail = "admin@BKLedgerApp.com".ToUpper(),
                NormalizedUserName = "admin@bkledgerapp".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };
            PasswordHasher<Core_ApplicationUser> ph1 = new PasswordHasher<Core_ApplicationUser>();
            appUser.PasswordHash = ph1.HashPassword(appUser, "Borazjan11!");
            builder.Entity<Core_ApplicationUser>().HasData(appUser);

            Core_ApplicationUser adminUser = new Core_ApplicationUser
            {
                UserName = "user@BKLedgerApp.com",
                Email = "user@BKLedgerApp.com",
                NormalizedEmail = "user@BKLedgerApp.com".ToUpper(),
                NormalizedUserName = "user@bkledgerapp".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };
            PasswordHasher<Core_ApplicationUser> ph2 = new PasswordHasher<Core_ApplicationUser>();
            adminUser.PasswordHash = ph2.HashPassword(appUser, "Borazjan11!");
            builder.Entity<Core_ApplicationUser>().HasData(adminUser);

            #endregion

            #region Ledger
            
            var Ledger1 = new Core_Ledger
            { Name = "Ledger_01", Created = DateTime.Now, Modified = DateTime.Now,
                CreatedById = adminUser.Id, ModifiedById = adminUser.Id, OwnerId = adminUser.Id};
            var Ledger2 = new Core_Ledger
            { Name = "Ledger_02", Created = DateTime.Now, Modified = DateTime.Now,
                CreatedById = adminUser.Id, ModifiedById = adminUser.Id, OwnerId = appUser.Id};
            builder.Entity<Core_Ledger>().HasData(Ledger1, Ledger2);
            #endregion

            #region LedgerMembership

            var LedgerMemberships = new[]
            {
                new Core_LedgerMembership{ LedgerId = Ledger1.Id, LedgerMemberId = adminUser.Id,
                    Created = DateTime.Now, Modified = DateTime.Now, CreatedById = adminUser.Id, ModifiedById = adminUser.Id },
                new Core_LedgerMembership{ LedgerId = Ledger1.Id, LedgerMemberId = appUser.Id,
                    Created = DateTime.Now, Modified = DateTime.Now, CreatedById = appUser.Id, ModifiedById = appUser.Id },
                new Core_LedgerMembership{ LedgerId = Ledger2.Id, LedgerMemberId = adminUser.Id,
                    Created = DateTime.Now, Modified = DateTime.Now, CreatedById = adminUser.Id, ModifiedById = adminUser.Id },
                new Core_LedgerMembership{ LedgerId = Ledger2.Id, LedgerMemberId = appUser.Id,
                    Created = DateTime.Now, Modified = DateTime.Now, CreatedById = appUser.Id, ModifiedById = appUser.Id }
            };


            builder.Entity<Core_LedgerMembership>().HasData(LedgerMemberships[0], LedgerMemberships[1], LedgerMemberships[2], LedgerMemberships[3]);

            #endregion

            #region Transactions

            var Transactions = new []
            {
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = appUser.Id, PayerID = adminUser.Id, 
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id },
                new Core_Transaction{LedgerId = Ledger1.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id },
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger1.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},

                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id },
                new Core_Transaction{LedgerId = Ledger2.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id },
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = appUser.Id, PayerID = adminUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
                new Core_Transaction{ LedgerId = Ledger2.Id, PayeeID = adminUser.Id, PayerID = appUser.Id,
                    Amount = new Random().Next()*10, CreatedById = appUser.Id, ModifiedById = appUser.Id},
            };
            builder.Entity<Core_Transaction>().HasData(Transactions[0], Transactions[1], Transactions[2], Transactions[3], Transactions[4]
                , Transactions[5], Transactions[6], Transactions[7], Transactions[8], Transactions[9], Transactions[10], Transactions[11]
                , Transactions[12], Transactions[13], Transactions[14], Transactions[15], Transactions[16], Transactions[17]);
            #endregion



            base.OnModelCreating(builder);
        }
    }
}
