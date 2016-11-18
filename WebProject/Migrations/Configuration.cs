namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<WebProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebProject.Models.ApplicationDbContext context)
        {
            var manager =
                 new UserManager<ApplicationUser>(
                     new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));



            roleManager.Create(new IdentityRole { Name = "Admin" });
            roleManager.Create(new IdentityRole { Name = "Customer" });


            context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            {
                Id = "000001",
                Email = "S00001@mail.com",
                EmailConfirmed = true,
                UserName = "S00001@mail.com",
                PasswordHash = new PasswordHasher().HashPassword("0001$"),
                SecurityStamp = Guid.NewGuid().ToString(),
            });

            context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            {
                Id = "JimM",
                Email = "Jim@gmail.com",
                EmailConfirmed = true,
                UserName = "Jim@gmail.com",
                PasswordHash = new PasswordHasher().HashPassword("jim$"),
                SecurityStamp = Guid.NewGuid().ToString(),
            });


            ApplicationUser admin = manager.FindByEmail("Jim@gmail.com");
            if (admin != null)
            {
                manager.AddToRoles(admin.Id, new string[] { "Admin", "Customer" });
            }
            ApplicationUser Customer = manager.FindByEmail("S00001@mail.com");
            if (Customer != null)
            {
                manager.AddToRoles(Customer.Id, new string[] { "Customer" });
            }
        }
    }
}
