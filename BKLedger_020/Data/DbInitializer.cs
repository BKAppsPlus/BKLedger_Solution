using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BKLedger_020.Data
{
    public static class DbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            //if (userManager.FindByEmailAsync("bkashefipour@gmail.com").Result == null)
            //{
            //    IdentityUser user = new IdentityUser
            //    {
            //        UserName = "admin@BKLedgerApp.com",
            //        Email = "admin@BKLedgerApp.com"
            //    };

            //    IdentityResult result = userManager.CreateAsync(user, "Kolooche11!").Result;

            //    if (result.Succeeded)
            //    {
            //        userManager.AddToRoleAsync(user, "Admin").Wait();
            //    }
            //}
        }

    }
}