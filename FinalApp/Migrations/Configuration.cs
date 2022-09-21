namespace FinalApp.Migrations
{
    using FinalApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<FinalApp.Models.ApplicationDbContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = true;
//        }

        protected override void Seed(FinalApp.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Admin" };
                manager.Create(role);
            }
            if (!context.Roles.Any(x => x.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Customer" };
                manager.Create(role);
            }
            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com",
                    Email = "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com",
                    PasswordHash = PasswordHash.HashPassword("Lampater123#")
                };
                manager.Create(user);
                manager.AddToRole(user.Id,"Admin");
            }
            if (!context.Users.Any(x => x.UserName == "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com",
                    Email = "matthaios-nikolaos.kollaros@peoplecert.onmicrosoft.com",
                    PasswordHash = PasswordHash.HashPassword("Lampater123#")
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }
            if (!context.Users.Any(x => x.UserName == "zafiris.argyros@peoplecert.onmicrosoft.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "zafiris.argyros@peoplecert.onmicrosoft.com",
                    Email = "zafiris.argyros@peoplecert.onmicrosoft.com",
                    PasswordHash = PasswordHash.HashPassword("Lampater123#")
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
