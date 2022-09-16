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
    internal class MockupDbInitilializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region Game Seeding

            Game g1 = new Game() 
            { 
                Title = "Fifa 23", 
                Price = 10, 
                Rating = 10, 
                ReleaseDate = new DateTime(2022, 09, 30), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a6/FIFA_23_Cover.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=o3V-GvvzjE4",
                
            };
            Game g2 = new Game() 
            { 
                Title = "The Legend of Zelda", 
                Price = 5, 
                Rating = 3, 
                ReleaseDate = new DateTime(1986, 02, 21), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/d/d0/Zelda_Cover_Europe.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=c4bvZZa5Mtg",
                
            };
            Game g3 = new Game() 
            { 
                Title = "Tetris", 
                Price = 3, 
                Rating = 6, 
                ReleaseDate = new DateTime(1986, 01, 01), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/8/8d/NES_Tetris_Box_Front.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=QYIXBj7YMeA"
            };
            Game g4 = new Game() 
            { 
                Title = "Starcraft", 
                Price = 10, 
                Rating = 9, 
                ReleaseDate = new DateTime(1998, 03, 31), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/93/StarCraft_box_art.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=H4Z6Rmbtk1k"
            };
            Game g5 = new Game() 
            { 
                Title = "Diablo", 
                Price = 5, 
                Rating = 5, 
                ReleaseDate = new DateTime(1997, 01, 03), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/3/3a/Diablo_Coverart.png", 
                VideoUrl = "https://www.youtube.com/watch?v=o_Kr5i5F43U"
            };

            context.Games.AddOrUpdate(g1, g2, g3, g4, g5);
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
            Genre gen9 = new Genre() { Kind = "MOBA" };
            Genre gen10 = new Genre() { Kind = "Fighting" };
            Genre gen11 = new Genre() { Kind = "Platform" };

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8, gen9, gen10, gen11);
            context.SaveChanges();

            #endregion

            #region Company Seeding

            Company c1 = new Company() { Name = "Blizzard", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/SEGA_logo.svg/300px-SEGA_logo.svg.png" };
            Company c2 = new Company() { Name = "Sierra", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/Sierra_former_logo.svg/300px-Sierra_former_logo.svg.png" };
            Company c3 = new Company() { Name = "Riot Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5b/Riot_Games_2022.svg/500px-Riot_Games_2022.svg.png?20220302230728" };
            Company c4 = new Company() { Name = "Paradox Interactive", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d0/Paradox_Interactive_logo.svg/800px-Paradox_Interactive_logo.svg.png" };
            Company c5 = new Company() { Name = "Ubisoft", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Ubisoft_logo.svg/655px-Ubisoft_logo.svg.png" };
            Company c6 = new Company() { Name = "Square", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Square_Logo.svg/606px-Square_Logo.svg.png" };
            Company c7 = new Company() { Name = "Nintendo", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Nintendo.svg/600px-Nintendo.svg.png?20170720163516" };
            Company c8 = new Company() { Name = "Sega", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/SEGA_logo.svg/300px-SEGA_logo.svg.png" };
            Company c9 = new Company() { Name = "Electronic Arts", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e5/Electronic_Arts_Logo_2020.png" };
            Company c10 = new Company() { Name = "BioWare", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/BioWare_2018.svg/1920px-BioWare_2018.svg.png" };
            Company c11 = new Company() { Name = "Valve", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Valve_logo.svg/800px-Valve_logo.svg.png" };
            Company c12 = new Company() { Name = "Microsoft", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Microsoft_logo_%282012%29.svg/512px-Microsoft_logo_%282012%29.svg.png?20210729021037" };
            Company c13 = new Company() { Name = "Owlcat Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/ru/d/d4/Owlcat_Games_full_logo.png" };
            Company c14 = new Company() { Name = "Klei Entertainment", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Klei_Entertainment.svg/200px-Klei_Entertainment.svg.png?20220612200941" };
            Company c15 = new Company() { Name = "Capcom", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Capcom_logo.svg/1920px-Capcom_logo.svg.png" };
            Company c16 = new Company() { Name = "Lucasfilm Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d1/Lucasfilm_Games_Logo.png" };
            Company c17 = new Company() { Name = "Player First Games", PhotoUrl = "https://cdn.multiversus.com/static/player-first.png" };

            context.Companies.AddOrUpdate(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17);
            context.SaveChanges();

            #endregion

            #region Populating Lists

            // Adding Companies to Games
            g1.Company = c9;
            g2.Company = c7;
            g3.Company = c17;
            g4.Company = c1;
            g5.Company = c1;

            // Adding Genres to Games
            g1.Genres = new List<Genre>() { gen8 };
            g2.Genres = new List<Genre>() { gen2 };
            g3.Genres = new List<Genre>() { gen3 };
            g4.Genres = new List<Genre>() { gen6 };
            g5.Genres = new List<Genre>() { gen1, gen4 };

            // Adding Games to Companies
            c1.Games = new List<Game>() { g4, g5 };
            c7.Games = new List<Game>() { g2 };
            c9.Games = new List<Game>() { g1 };
            c17.Games = new List<Game>() { g3 };

            // Adding Games to Genres
            gen1.Games = new List<Game>() { g5 , g1 };
            gen2.Games = new List<Game>() { g2 };
            gen3.Games = new List<Game>() { g3 };
            gen4.Games = new List<Game>() { g5 };
            gen6.Games = new List<Game>() { g4 };

            context.SaveChanges();

            #endregion
        }
    }
}

