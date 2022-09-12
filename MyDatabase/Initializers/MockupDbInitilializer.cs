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

            Game g1 = new Game() { Title = "Fifa 23", Price = 10 , Rating = 10, ReleaseDate = new DateTime(2022,09,30), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a6/FIFA_23_Cover.jpg" };
            Game g2 = new Game() { Title = "The Legend of Zelda", Price = 5, Rating = 3, ReleaseDate = new DateTime(1986,02,21), PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/d/d0/Zelda_Cover_Europe.jpg"  };
            Game g3 = new Game() { Title = "Tetris", Price = 3, Rating = 6, ReleaseDate = new DateTime(1986,01,01), PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/8/8d/NES_Tetris_Box_Front.jpg"   };
            Game g4 = new Game() { Title = "Starcraft", Price = 10, Rating = 9, ReleaseDate = new DateTime(1998,03,31), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/93/StarCraft_box_art.jpg" };
            Game g5 = new Game() { Title = "Diablo", Price = 5, Rating = 5, ReleaseDate = new DateTime(1997,01,03), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/3/3a/Diablo_Coverart.png"  };
            Game g6 = new Game() { Title = "Mass Effect", Price = 20, Rating = 5, ReleaseDate = new DateTime(2007,11,20), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e8/MassEffect.jpg"  };
            Game g7 = new Game() { Title = "Dragon Age: Origins", Price = 10, Rating = 10, ReleaseDate = new DateTime(2009,11,03), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/89/Dragon_Age_Origins_cover.png"  };
            Game g8 = new Game() { Title = "Half-Life", Price = 70, Rating = 1, ReleaseDate = new DateTime(1998,11,19), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/f/fa/Half-Life_Cover_Art.jpg"  };
            Game g9 = new Game() { Title = "Age of Empires II", Price = 15, Rating = 3, ReleaseDate = new DateTime(1999,09,30), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Age_of_Empires_II_-_The_Age_of_Kings_Coverart.png"  };
            Game g10 = new Game() { Title = "Starcraft II", Price = 20, Rating = 4, ReleaseDate = new DateTime(2010,07,27), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/2/20/StarCraft_II_-_Box_Art.jpg"  };
            Game g11 = new Game() { Title = "Diablo II", Price = 10, Rating = 5, ReleaseDate = new DateTime(2000,06,30), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png"  };
            Game g12 = new Game() { Title = "Pathfinder: Kingmaker", Price = 30, Rating = 3, ReleaseDate = new DateTime(2018,09,25), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e6/Pathfinder_Kingmaker_cover_art.jpg"  };
            Game g13 = new Game() { Title = "Oxygen Not Included", Price = 25, Rating = 8, ReleaseDate = new DateTime(2019,07,30), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/f/f6/Oxygen_Not_Included_cover_art.jpg"  };
            Game g14 = new Game() { Title = "Minecraft", Price = 30, Rating = 8, ReleaseDate = new DateTime(2009,05,17), PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/8/82/Minecraft_cover.jpg"  };
            Game g15 = new Game() { Title = "Diablo III", Price = 15, Rating = 4, ReleaseDate = new DateTime(2012,05,15), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png"  };
            Game g16 = new Game() { Title = "Cities: Skylines", Price = 20, Rating = 6, ReleaseDate = new DateTime(2015,03,10), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/58/Cities_Skylines_cover_art.jpg"  };
            Game g17 = new Game() { Title = "Final Fantasy VII", Price = 7, Rating = 3, ReleaseDate = new DateTime(1997,01,30), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c2/Final_Fantasy_VII_Box_Art.jpg"  };
            Game g18 = new Game() { Title = "Resident Evil", Price = 9, Rating = 4, ReleaseDate = new DateTime(1996/03/22), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a6/Resident_Evil_1_cover.png"  };
            Game g19 = new Game() { Title = "The Secret of Monkey Island", Price = 15, Rating = 10, ReleaseDate = new DateTime(1990/10/01), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a8/The_Secret_of_Monkey_Island_artwork.jpg"  };
            Game g20 = new Game() { Title = "DotA 2", Price = 60, Rating = 5, ReleaseDate = new DateTime(2013/07/09), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/0/0b/Dota_2_%28Steam_2019%29.jpg"  };
            Game g21 = new Game() { Title = "MultiVersus", Price = 50, Rating = 7, ReleaseDate = new DateTime(2022/08/15), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/1d/MultiVersus_Cover_Art.png"  };
            Game g22 = new Game() {Title = "Fallout", Price = 30, Rating = 9, ReleaseDate = new DateTime (1997,10,10), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/af/Fallout.jpg?20210820180451" };
            Game g23 = new Game() {Title = "League of Legends",  Rating = 6, Price = 0, ReleaseDate = new DateTime (2013,03,01), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/League_of_Legends_2019_vector.svg/900px-League_of_Legends_2019_vector.svg.png" };
            Game g24 = new Game() {Title = "Far Cry", Price = 15, Rating = 9, ReleaseDate = new DateTime(2004,03,23) PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Far_Cry_1_boxshot.jpg" };
            Game g25 = new Game() {Title = "Sonic the Hedgehog", Rating = 4, Price = 8, ReleaseDate = new DateTime(1991,06,23), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/b/ba/Sonic_the_Hedgehog_1_Genesis_box_art.jpg?20150330215349" };
            Game g26 = new Game() {Title = "World of Warcraft", Rating = 6, Price = 18, ReleaseDate = new DateTime(2004,11,23), PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png" };

            
            context.Games.AddOrUpdate(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21);
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

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8);
            context.SaveChanges();
            #endregion

            #region Company Seeding

            Company c1 = new Company() { Name = "Blizzard", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/SEGA_logo.svg/300px-SEGA_logo.svg.png"};
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

            context.Companies.AddOrUpdate(c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17);
            context.SaveChanges();
            #endregion
            
            #region Populating Lists
            
            g1.Company = new List<Company> { c9 };
            g2.Company = new List<Company> { c7 };
            g3.Company = new List<Company> { c17 };
            g4.Company = new List<Company> { c1 };
            g5.Company = new List<Company> { c1 };
            g6.Company = new List<Company> { c10 };
            g7.Company = new List<Company> { c10 };
            g8.Company = new List<Company> { c11 };
            g9.Company = new List<Company> { c12 };
            g10.Company = new List<Company> { c1 };
            g11.Company = new List<Company> { c1 };
            g12.Company = new List<Company> { c13 };
            g13.Company = new List<Company> { c14 };
            g14.Company = new List<Company> { c12 };
            g15.Company = new List<Company> { c1 };
            g16.Company = new List<Company> { c4 };
            g17.Company = new List<Company> { c6 };
            g18.Company = new List<Company> { c15 };
            g19.Company = new List<Company> { c16 };
            g20.Company = new List<Company> { c11 };
            g21.Company = new List<Company> { c17 };
            g22.Company = new List<Company> { c3 };
            g23.Company = new List<Company> { c2 };
            g24.Company = new List<Company> { c5 };
            g25.Company = new List<Company> { c8 };
            g26.Company = new List<Company> { c1 };
            
            g1.Genres = new List<Genre> { gen8 };            
            g2.Genres = new List<Genre> { gen2};            
            g3.Genres = new List<Genre> { gen3 };            
            g4.Genres = new List<Genre> { gen6 };            
            g5.Genres = new List<Genre> { gen1, gen4 };            
            g6.Genres = new List<Genre> { gen4 };            
            g7.Genres = new List<Genre> { gen4 };            
            g8.Genres = new List<Genre> { gen2 };            
            g9.Genres = new List<Genre> { gen6 };            
            g10.Genres = new List<Genre> { gen6 };            
            g11.Genres = new List<Genre> { gen1, gen4 };            
            g12.Genres = new List<Genre> { gen4 };            
            g13.Genres = new List<Genre> { gen5 };            
            g14.Genres = new List<Genre> { gen5 };            
            g15.Genres = new List<Genre> { gen1, gen4 };            
            g16.Genres = new List<Genre> { gen5 };            
            g17.Genres = new List<Genre> { gen4 };            
            g18.Genres = new List<Genre> { gen2 };            
            g19.Genres = new List<Genre> { gen2 };            
            g20.Genres = new List<Genre> { gen9 };            
            g21.Genres = new List<Genre> { gen10 };          
            g22.Genres = new List<Genre> { gen2 };          
            g23.Genres = new List<Genre> { gen9 };          
            g24.Genres = new List<Genre> { gen2 };          
            g25.Genres = new List<Genre> { gen11 };        
            g26.Genres = new List<Genre> { gen8 };
            
            c1.Games = new List<Game> { g4, g5, g10, g11, g15, g26 };
            c2.Games = new List<Game> { g22 };
            c3.Games = new List<Game> { g23 };
            c4.Games = new List<Game> { g16 };
            c5.Games = new List<Game> { g24 };
            c6.Games = new List<Game> { g17 };
            c7.Games = new List<Game> { g2 };
            c8.Games = new List<Game> { g25 };
            c9.Games = new List<Game> { g1};
            c10.Games = new List<Game> { g6, g7 };
            c11.Games = new List<Game> { g8, g20 };
            c12.Games = new List<Game> { g9, g14 };
            c13.Games = new List<Game> { g12 };
            c14.Games = new List<Game> { g13 };
            c15.Games = new List<Game> { g18 };
            c16.Games = new List<Game> { g19};
            c17.Games = new List<Game> { g3, g21 };
            
            gen1.Games = new List<Game> { g5, g11, g15};
            gen2.Games = new List<Game> { g2, g8, g18, g19, g22, g24};
            gen3.Games = new List<Game> { g3 };
            gen4.Games = new List<Game> { g5, g6, g7, g11, g12, g15, g17};
            gen5.Games = new List<Game> { g13, g14, g16};
            gen6.Games = new List<Game> { g4, g9, g10};
            gen7.Games = new List<Game> { g26 };
            gen8.Games = new List<Game> { g26 };
            gen9.Games = new List<Game> { g20, g23 };
            gen10.Games = new List<Game> { g21 };
            gen11.Games = new List<Game> { g25 };
            
            #endregion

        }
    }
}
