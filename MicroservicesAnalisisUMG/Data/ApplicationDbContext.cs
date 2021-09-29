using MicroservicesAnalisisUMG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesAnalisisUMG.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        // set Modules
        public DbSet<Posit> Posit { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public static async Task SeedData(UserManager<IdentityUser> userManager)
        {
            await SeedUsers(userManager);
        }

        public static async Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if(userManager.FindByNameAsync("victor").Result == null)
            {
                // create User in update database
                var user = new IdentityUser
                {
                    UserName = "victorTx",
                    Email = "victor@example.com",
                };
                _ = userManager.CreateAsync(user, "@Pass123").Result;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
