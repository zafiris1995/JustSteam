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
    internal class MockupDbInitilializer : CreateDatabaseIfNotExists<ApplicationDbContext>
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
            Game g6 = new Game() 
            { 
                Title = "Mass Effect", 
                Price = 20, Rating = 5, 
                ReleaseDate = new DateTime(2007, 11, 20), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e8/MassEffect.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=-_6ZMr2bMco" 
            };
            Game g7 = new Game() 
            { 
                Title = "Dragon Age: Origins", 
                Price = 10, 
                Rating = 10, 
                ReleaseDate = new DateTime(2009, 11, 03), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/89/Dragon_Age_Origins_cover.png", 
                VideoUrl = "https://www.youtube.com/watch?v=4k81SFkhFG4" 
            };
            Game g8 = new Game() 
            { 
                Title = "Half-Life", 
                Price = 70, 
                Rating = 1, 
                ReleaseDate = new DateTime(1998, 11, 19), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/f/fa/Half-Life_Cover_Art.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=5Wavn29LMrs" 
            };
            Game g9 = new Game() 
            { 
                Title = "Age of Empires II", 
                Price = 15, 
                Rating = 3, 
                ReleaseDate = new DateTime(1999, 09, 30), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Age_of_Empires_II_-_The_Age_of_Kings_Coverart.png", 
                VideoUrl = "https://www.youtube.com/watch?v=ZOgBVR21pWg" 
            };
            Game g10 = new Game() 
            { 
                Title = "Starcraft II: Wings of Liberty", 
                Price = 20, Rating = 8, 
                ReleaseDate = new DateTime(2010, 07, 27), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/2/20/StarCraft_II_-_Box_Art.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=VSGmPpidDvo" 
            };
            Game g11 = new Game() 
            { 
                Title = "Diablo II", 
                Price = 10, Rating = 5, 
                ReleaseDate = new DateTime(2000, 06, 30), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 
                VideoUrl = "https://www.youtube.com/watch?v=KxnWjyvmpnI" 
            };
            Game g12 = new Game() 
            { 
                Title = "Pathfinder: Kingmaker", 
                Price = 30, Rating = 3, 
                ReleaseDate = new DateTime(2018, 09, 25), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e6/Pathfinder_Kingmaker_cover_art.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=MrP8-wuZSoU" 
            };
            Game g13 = new Game() 
            { 
                Title = "Oxygen Not Included", 
                Price = 25, Rating = 8, 
                ReleaseDate = new DateTime(2019, 07, 30), 
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/f/f6/Oxygen_Not_Included_cover_art.jpg", 
                VideoUrl = "https://www.youtube.com/watch?v=wcLayGm_pM4" 
            };


            context.Games.AddOrUpdate(g1, g2, g3, g4, g5, g6 ,g7, g8, g9, g10, g11, g12, g13);
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
            g6.Company = c9;
            g7.Company = c10;
            g8.Company = c11;
            g9.Company = c12;
            g10.Company = c1;
            g11.Company = c1;
            g12.Company = c13;
            g13.Company = c14;

            // Adding Genres to Games
            g1.Genres = new List<Genre>() { gen8 };
            g2.Genres = new List<Genre>() { gen2 };
            g3.Genres = new List<Genre>() { gen3 };
            g4.Genres = new List<Genre>() { gen6 };
            g5.Genres = new List<Genre>() { gen1, gen4 };
            g6.Genres = new List<Genre>() { gen4 };
            g7.Genres = new List<Genre>() { gen4 };
            g8.Genres = new List<Genre>() { gen4 };
            g9.Genres = new List<Genre>() { gen6 };
            g10.Genres = new List<Genre>() { gen6 };
            g11.Genres = new List<Genre>() { gen1, gen4 };
            g12.Genres = new List<Genre>() { gen4 };
            g13.Genres = new List<Genre>() { gen5 };

            // Adding Games to Companies
            c1.Games = new List<Game>() { g4, g5 };
            c7.Games = new List<Game>() { g2 };
            c9.Games = new List<Game>() { g1 };
            c10.Games = new List<Game>() { g7 };
            c11.Games = new List<Game>() { g8 };
            c12.Games = new List<Game>() { g9 };
            c13.Games = new List<Game>() { g12 };
            c14.Games = new List<Game>() { g13 };
            c17.Games = new List<Game>() { g3 };

            // Adding Games to Genres
            gen1.Games = new List<Game>() { g5, g11 };
            gen2.Games = new List<Game>() { g2 };
            gen3.Games = new List<Game>() { g3 };
            gen4.Games = new List<Game>() { g5, g7, g8, g11, g12 };
            gen5.Games = new List<Game>() { g1, g13 };
            gen6.Games = new List<Game>() { g4 };

            context.SaveChanges();

            #endregion

            #region Populating Lists
            
            // Adding companies to games
            g1.Company = c9;
            g2.Company = c7;
            g3.Company = c17;
            g4.Company = c1;
            g5.Company = c1;
            g6.Company = c10;
            g7.Company = c10;
            g8.Company = c11;
            g9.Company = c12;
            g10.Company = c1;
            g11.Company = c1;
            g12.Company = c13;
            g13.Company = c14;
            g14.Company = c12;
            g15.Company = c1;
            g16.Company = c4;
            g17.Company = c6;
            g18.Company = c15;
            g19.Company = c16;
            g20.Company = c11;
            g21.Company = c17;
            g22.Company = c18;
            g23.Company = c2;
            g24.Company = c5;
            g25.Company = c8;
            g26.Company = c1;
            g27.Company = c19;
            g28.Company = c19;
            g29.Company = c9;
            g30.Company = c20;
            g31.Company = c21;
            g32.Company = c22;
            g33.Company = c11;
            g34.Company = c23;
            g35.Company = c24;
            g36.Company = c25;
            g37.Company = c25;
            g38.Company = c25;
            g39.Company = c10;
            g40.Company = c10;
            g41.Company = c10;
            g42.Company = c26;
            g43.Company = c26;
            g44.Company = c27;
            g45.Company = c28;
            g46.Company = c1;
            g47.Company = c1;
            g48.Company = c1;
            g49.Company = c9;
            g50.Company = c29;
            g51.Company = c30;
            g52.Company = c31;
            g53.Company = c32;
            g54.Company = c32;
            g55.Company = c32;
            g56.Company = c32;
            g57.Company = c32;
            g58.Company = c33;
            g59.Company = c34;
            g60.Company = c34;
            
            // Adding genres to games
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
            g27.Genres = new List<Genre> { gen12 };
            g28.Genres = new List<Genre> { gen12 };
            g29.Genres = new List<Genre> { gen5 };
            g30.Genres = new List<Genre> { gen4 };
            g31.Genres = new List<Genre> { gen5, gen6 };
            g32.Genres = new List<Genre> { gen5, gen6 };
            g33.Genres = new List<Genre> { gen12 };
            g34.Genres = new List<Genre> { gen6 };
            g35.Genres = new List<Genre> { gen4 };
            g36.Genres = new List<Genre> { gen6 };
            g37.Genres = new List<Genre> { gen6 };
            g38.Genres = new List<Genre> { gen6 };
            g39.Genres = new List<Genre> { gen4 };
            g40.Genres = new List<Genre> { gen4, gen12 };
            g41.Genres = new List<Genre> { gen4, gen12 };
            g42.Genres = new List<Genre> { gen4, gen12 };
            g43.Genres = new List<Genre> { gen4, gen12 };
            g44.Genres = new List<Genre> { gen1, gen4};
            g45.Genres = new List<Genre> { gen1, gen2, gen5};
            g46.Genres = new List<Genre> { gen6 };
            g47.Genres = new List<Genre> { gen6 };
            g48.Genres = new List<Genre> { gen6 };
            g49.Genres = new List<Genre> { gen5 };
            g50.Genres = new List<Genre> { gen5 };
            g51.Genres = new List<Genre> { gen4 };
            g52.Genres = new List<Genre> { gen4 };
            g53.Genres = new List<Genre> { gen6 };
            g54.Genres = new List<Genre> { gen6 };
            g55.Genres = new List<Genre> { gen6 };
            g56.Genres = new List<Genre> { gen6 };
            g57.Genres = new List<Genre> { gen6 };
            g58.Genres = new List<Genre> { gen6 };
            g59.Genres = new List<Genre> { gen6 };
            g60.Genres = new List<Genre> { gen6 };
            
            // Adding games to companies           
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
            c16.Games = new List<Game> { g19 };
            c17.Games = new List<Game> { g3, g21 };
            c18.Games = new List<Game> { g22 };
            c19.Games = new List<Game> { g27, g28 };
            c20.Games = new List<Game> { g30 };
            c21.Games = new List<Game> { g31 };
            c22.Games = new List<Game> { g32 };
            c23.Games = new List<Game> { g34 };
            c24.Games = new List<Game> { g35};
            c25.Games = new List<Game> { g36, g37, g38 };
            c26.Games = new List<Game> { g42, g43 };
            c27.Games = new List<Game> { g44 };
            c28.Games = new List<Game> { g45 };
            c29.Games = new List<Game> { g50 };
            c30.Games = new List<Game> { g51 };
            c31.Games = new List<Game> { g52 };
            c32.Games = new List<Game> { g53, g54, g55, g56, g57};
            c33.Games = new List<Game> { g58 };
            c34.Games = new List<Game> { g59, g60 };
            
            // Adding games to genres
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
            gen12.Games = new List<Game> { g27, g28, g33, g40, g41, g42, g43 };
            
            #endregion

        }
    }
}

