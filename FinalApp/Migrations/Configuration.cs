//namespace FinalApp.Migrations
//{
//    using Microsoft.AspNet.Identity;
//    using Microsoft.AspNet.Identity.EntityFramework;
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<FinalApp.Models.ApplicationDbContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = true;
//        }

//        protected override void Seed(FinalApp.Models.ApplicationDbContext context)
//        {
//            if (!context.Roles.Any(x => x.Name == "Admin"))
//            {
//                var store = new RoleStore<IdentityRole>(context);
//                var manager = new RoleManager<IdentityRole>(store);
//                var role = new IdentityRole() { Name = "Admin" };
//                manager.Create(role);
//            }
//            if (!context.Roles.Any(x => x.Name == "Customer"))
//            {
//                var store = new RoleStore<IdentityRole>(context);
//                var manager = new RoleManager<IdentityRole>(store);
//                var role = new IdentityRole() { Name = "Customer" };
//                manager.Create(role);
//            }
//        }
//    }
//}
