using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    internal class MockupDbInitilializer :DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region Game Seeding

            Game g1 = new Game() { Title = "Fifa", Price = 10 };
            Game g2 = new Game() { Title = "Zelda", Price = 5 };
            Game g3 = new Game() { Title = "Tetris", Price = 3 };
            Game g4 = new Game() { Title = "Starcraft", Price = 10 };
            Game g5 = new Game() { Title = "Diablo", Price = 5 };
            Game g6 = new Game() { Title = "Mass Efect", Price = 20 };
            Game g7 = new Game() { Title = "Dragon Age: Origins", Price = 10 };
            Game g8 = new Game() { Title = "Half-Life 3", Price = 70 };
            Game g9 = new Game() { Title = "Age of Empires II", Price = 15 };
            Game g10 = new Game() { Title = "Starcraft II", Price = 20 };
            Game g11 = new Game() { Title = "Diablo II", Price = 10 };
            Game g12 = new Game() { Title = "Pathfinder: Kingmaker", Price = 30 };
            Game g13 = new Game() { Title = "Oxygen Not Included", Price = 25 };
            Game g14 = new Game() { Title = "Rimworld", Price = 30 };
            Game g15 = new Game() { Title = "Diablo III", Price = 15 };
            Game g16 = new Game() { Title = "Cities: Skylines", Price = 20 };
            Game g17 = new Game() { Title = "Final Fantasy VII", Price = 7 };
            Game g18 = new Game() { Title = "Resident Evil", Price = 9 };
            Game g19 = new Game() { Title = "Monkey Island", Price = 15 };
            Game g20 = new Game() { Title = "Diablo IV", Price = 60 };
            Game g21 = new Game() { Title = "MultiVersus", Price = 50 };

            context.Games.AddOrUpdate(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20);
            context.SaveChanges();

            #endregion

            #region Genre Seeding

            Genre gen1 = new Genre() { Kind = "Action" };
            Genre gen2 = new Genre() { Kind = "Adventure" };
            Genre gen3 = new Genre() { Kind = "Puzzle" };
            Genre gen4 = new Genre() { Kind = "RPG" };
            Genre gen5 = new Genre() { Kind = "Simulation" };
            Genre gen6 = new Genre() { Kind = "Strategy" };
            Genre gen7 = new Genre() { Kind = "Sports" };
            Genre gen8 = new Genre() { Kind = "MMO" };

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8);
            context.SaveChanges();
            #endregion

            #region Company Seeding

            Company c1 = new Company() { Name = "Blizzard" };
            Company c2 = new Company() { Name = "Sierra" };
            Company c3 = new Company() { Name = "Riot" };
            Company c4 = new Company() { Name = "Paradox" };
            Company c5 = new Company() { Name = "Ubisoft" };
            Company c6 = new Company() { Name = "Square " };
            Company c7 = new Company() { Name = "Nintendo" };
            Company c8 = new Company() { Name = "Sega" };

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8);
            context.SaveChanges();
            #endregion
        }
    }
}
