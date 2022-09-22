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
                Price = 20,
                Rating = 5,
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
                Price = 20,
                Rating = 8,
                ReleaseDate = new DateTime(2010, 07, 27),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/2/20/StarCraft_II_-_Box_Art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=VSGmPpidDvo"
            };
            Game g11 = new Game()
            {
                Title = "Diablo II",
                Price = 10,
                Rating = 5,
                ReleaseDate = new DateTime(2000, 06, 30),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=KxnWjyvmpnI"
            };
            Game g12 = new Game()
            {
                Title = "Pathfinder: Kingmaker",
                Price = 30,
                Rating = 3,
                ReleaseDate = new DateTime(2018, 09, 25),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e6/Pathfinder_Kingmaker_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=MrP8-wuZSoU"
            };
            Game g13 = new Game()
            {
                Title = "Oxygen Not Included",
                Price = 25,
                Rating = 8,
                ReleaseDate = new DateTime(2019, 07, 30),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/f/f6/Oxygen_Not_Included_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=wcLayGm_pM4"
            };
            Game g14 = new Game()
            {
                Title = "Minecraft",
                Price = 30,
                Rating = 8,
                ReleaseDate = new DateTime(2009, 05, 17),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/el/8/82/Minecraft_cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=MmB9b5njVbA"
            };
            Game g15 = new Game()
            {
                Title = "Diablo III",
                Price = 15,
                Rating = 4,
                ReleaseDate = new DateTime(2012, 05, 15),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png",
                VideoUrl = "https://www.youtube.com/watch?v=iktTUiHKLMg"
            };
            Game g16 = new Game()
            {
                Title = "Cities: Skylines",
                Price = 20,
                Rating = 6,
                ReleaseDate = new DateTime(2015, 03, 10),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/58/Cities_Skylines_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=0gI2N10QyRA"
            };
            Game g17 = new Game()
            {
                Title = "Final Fantasy VII",
                Price = 7,
                Rating = 3,
                ReleaseDate = new DateTime(1997, 01, 30),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c2/Final_Fantasy_VII_Box_Art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=utVE4aUKYuY"
            };
            Game g18 = new Game()
            {
                Title = "Resident Evil",
                Price = 9,
                Rating = 4,
                ReleaseDate = new DateTime(1996, 03, 22),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a6/Resident_Evil_1_cover.png",
                VideoUrl = "https://www.youtube.com/watch?v=TlpIbgaejh4"
            };
            Game g19 = new Game()
            {
                Title = "The Secret of Monkey Island",
                Price = 15,
                Rating = 10,
                ReleaseDate = new DateTime(1990 , 10 , 01),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a8/The_Secret_of_Monkey_Island_artwork.jpg",
                VideoUrl = ""
            };
            Game g20 = new Game()
            {
                Title = "DotA 2",
                Price = 60,
                Rating = 5,
                ReleaseDate = new DateTime(2013, 07, 09),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/0/0b/Dota_2_%28Steam_2019%29.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=-cSFPIwMEq4"
            };
            Game g21 = new Game()
            {
                Title = "MultiVersus",
                Price = 50,
                Rating = 7,
                ReleaseDate = new DateTime(2022, 08, 15),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/1d/MultiVersus_Cover_Art.png",
                VideoUrl = "https://www.youtube.com/watch?v=zvborgKG7fw"
            };
            Game g22 = new Game()
            {
                Title = "Fallout 4",
                Price = 30,
                Rating = 9,
                ReleaseDate = new DateTime(2015, 11, 10),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/70/Fallout_4_cover_art.jpg?20211024175025",
                VideoUrl = "https://www.youtube.com/watch?v=X5aJfebzkrM"
            };
            Game g23 = new Game()
            {
                Title = "League of Legends",
                Rating = 6,
                Price = 0,
                ReleaseDate = new DateTime(2013, 03, 01),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/League_of_Legends_2019_vector.svg/900px-League_of_Legends_2019_vector.svg.png",
                VideoUrl = "https://www.youtube.com/watch?v=cXZqfuJ9Zps"
            };
            Game g24 = new Game()
            {
                Title = "Far Cry",
                Price = 15,
                Rating = 9,
                ReleaseDate = new DateTime(2004, 03, 23),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Far_Cry_1_boxshot.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=1IhYnvb_dCk"
            };
            Game g25 = new Game()
            {
                Title = "Sonic the Hedgehog",
                Rating = 4,
                Price = 8,
                ReleaseDate = new DateTime(1991, 06, 23),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/b/ba/Sonic_the_Hedgehog_1_Genesis_box_art.jpg?20150330215349",
                VideoUrl = ""
            };
            Game g26 = new Game()
            {
                Title = "World of Warcraft",
                Rating = 6,
                Price = 18,
                ReleaseDate = new DateTime(2004, 11, 23),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png",
                VideoUrl = ""
            };
            Game g27 = new Game()
            {
                Title = "Doom",
                Rating = 6,
                Price = 20,
                ReleaseDate = new DateTime(1993, 12, 10),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/57/Doom_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=PHYcm9mTY4k"
            };
            Game g28 = new Game()
            {
                Title = "Quake III Arena",
                Rating = 8,
                Price = 30,
                ReleaseDate = new DateTime(1999, 12, 02),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a1/Quake3Title.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=NsL32y--h00"
            };
            Game g29 = new Game()
            {
                Title = "The Sims",
                Rating = 3,
                Price = 5,
                ReleaseDate = new DateTime(2000, 02, 11),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/The_Sims_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=tEOo9a2twkU"
            };
            Game g30 = new Game()
            {
                Title = "Baldur's Gate II: Shadows of Amn",
                Rating = 8,
                Price = 25,
                ReleaseDate = new DateTime(2000, 09, 29),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/17/Baldur%27s_Gate_II_-_Shadows_of_Amn_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=tONHtATupkw"
            };
            Game g31 = new Game()
            {
                Title = "Dungeon Keeper 2",
                Rating = 7,
                Price = 10,
                ReleaseDate = new DateTime(1999, 06, 20),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/4/48/Dungeon_Keeper_2_-_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=RntjbewkoQc"
            };
            Game g32 = new Game()
            {
                Title = "Black & White",
                Rating = 9,
                Price = 30,
                ReleaseDate = new DateTime(2001, 03, 30),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/7b/Black_%26_White_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=dm2kTfwT9HU"
            };
            Game g33 = new Game()
            {
                Title = "Counter-Strike",
                Rating = 5,
                Price = 10,
                ReleaseDate = new DateTime(2000, 11, 09),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Counter-Strike_Box.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=bvI62FUDpKA"
            };
            Game g34 = new Game()
            {
                Title = "Command & Conquer: Red Alert 2",
                Rating = 4,
                Price = 5,
                ReleaseDate = new DateTime(2000, 09, 27),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/Cncra2-win-cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=2YlVumsPHx4"
            };
            Game g35 = new Game()
            {
                Title = "Icewind Dale",
                Rating = 7,
                Price = 25,
                ReleaseDate = new DateTime(2000, 06, 29),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/3/38/Icewind_dale_1_box_shot.jpgv",
                VideoUrl = "https://www.youtube.com/watch?v=jb_3cg17TXw"
            };
            Game g36 = new Game()
            {
                Title = "Civilization IV",
                Rating = 1,
                Price = 15,
                ReleaseDate = new DateTime(2005, 11, 04),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/7e/CivIVboxshot.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=EuiM7Ycbm-k"
            };
            Game g37 = new Game()
            {
                Title = "Civilization III",
                Rating = 7,
                Price = 5,
                ReleaseDate = new DateTime(2002, 03, 01),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/7a/Civilization_III_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=3uE6HLIU0sA"
            };
            Game g38 = new Game()
            {
                Title = "Civilization V",
                Rating = 9,
                Price = 25,
                ReleaseDate = new DateTime(2010, 11, 23),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/5c/CIVILIZATION-V-FRONT-OF-BOX.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=4lEfl_OebvQ"
            };
            Game g39 = new Game()
            {
                Title = "Star Wars: Knights of the Old Republic",
                Rating = 9,
                Price = 10,
                ReleaseDate = new DateTime(2003, 07, 15),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/Kotorbox.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=QgbMAdtp7aE"
            };
            Game g40 = new Game()
            {
                Title = "Mass Effect 2",
                Rating = 7,
                Price = 20,
                ReleaseDate = new DateTime(2010, 01, 26),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/0/05/MassEffect2_cover.PNG",
                VideoUrl = "https://www.youtube.com/watch?v=lx9sPQpjgjU"
            };
            Game g41 = new Game()
            {
                Title = "Mass Effect 3",
                Rating = 5,
                Price = 30,
                ReleaseDate = new DateTime(2012, 03, 06),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/b/b0/Mass_Effect_3_Game_Cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=AluTOOCVXVQ"
            };
            Game g42 = new Game()
            {
                Title = "Red Dead Redemption",
                Rating = 4,
                Price = 15,
                ReleaseDate = new DateTime(2010, 05, 18),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/Red_Dead_Redemption.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=-o7rES_3ymA"
            };
            Game g43 = new Game()
            {
                Title = "Red Dead Redemption 2",
                Rating = 9,
                Price = 40,
                ReleaseDate = new DateTime(2019, 11, 05),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=eaW0tYpxyp0"
            };
            Game g44 = new Game()
            {
                Title = "Hades",
                Rating = 7,
                Price = 20,
                ReleaseDate = new DateTime(2021, 09, 13),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/cc/Hades_cover_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=91t0ha9x0AE"
            };
            Game g45 = new Game()
            {
                Title = "Cult of the Lamb",
                Rating = 4,
                Price = 13,
                ReleaseDate = new DateTime(2022, 08, 11),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/d4/Cult_of_the_Lamb_Key_Art.png",
                VideoUrl = "https://www.youtube.com/watch?v=xsPtUNB1z-Q"
            };
            Game g46 = new Game()
            {
                Title = "Starcraft II: Heart of the Swarm",
                Rating = 7,
                Price = 15,
                ReleaseDate = new DateTime(2013, 03, 12),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/b/b8/SC2_Heart_of_the_Swarm_cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=MVbeoSPqRs4"
            };
            Game g47 = new Game()
            {
                Title = "Starcraft II: Legacy of the Void",
                Rating = 8,
                Price = 15,
                ReleaseDate = new DateTime(2015, 11, 10),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/77/StarCraft_II_-_Legacy_of_the_Void_cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=M_XwzBMTJaM"
            };
            Game g48 = new Game()
            {
                Title = "Starcraft: Brood Wars",
                Rating = 4,
                Price = 10,
                ReleaseDate = new DateTime(1998, 12, 18),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/89/Brood_War_box_art_%28StarCraft%29.jpg",
                VideoUrl = ""
            };
            Game g49 = new Game()
            {
                Title = "Simcity",
                Rating = 7,
                Price = 3,
                ReleaseDate = new DateTime(1989, 02, 02),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/7/7b/SimCity_Classic_cover_art.jpg",
                VideoUrl = ""
            };
            Game g50 = new Game()
            {
                Title = "RollerCoaster Tycoon",
                Rating = 5,
                Price = 5,
                ReleaseDate = new DateTime(1999, 04, 12),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/1d/Rct-box.jpg",
                VideoUrl = ""
            };
            Game g51 = new Game()
            {
                Title = "Vampire: The Masquerade – Redemption",
                Rating = 8,
                Price = 10,
                ReleaseDate = new DateTime(2001, 06, 07),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Vampire_The_Masquerade_Redemption_Cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=V7uLwDmB9xE"
            };
            Game g52 = new Game()
            {
                Title = "Vampire: The Masquerade – Bloodlines",
                Rating = 8,
                Price = 20,
                ReleaseDate = new DateTime(2004, 11, 19),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/96/Vampire_-_The_Masquerade_%E2%80%93_Bloodlines_Coverart.png",
                VideoUrl = "https://www.youtube.com/watch?v=yRNZWZ9Y0L0"
            };
            Game g53 = new Game()
            {
                Title = "Warhammer 40,000: Dawn of War",
                Rating = 7,
                Price = 5,
                ReleaseDate = new DateTime(2004, 09, 20),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/9f/Dawn_of_War_box_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=_oqr06cHAGw"
            };
            Game g54 = new Game()
            {
                Title = "Warhammer 40,000: Dawn of War - Winter Assault",
                Rating = 5,
                Price = 5,
                ReleaseDate = new DateTime(2005, 09, 23),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/WA_Box_art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=ItfjAvGeL1Y"
            };
            Game g55 = new Game()
            {
                Title = "Warhammer 40,000: Dawn of War - Dark Crusade",
                Rating = 6,
                Price = 10,
                ReleaseDate = new DateTime(2006, 11, 03),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/d3/DC_Box_Art.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=1P6UJQnD0uU"
            };
            Game g56 = new Game()
            {
                Title = "Warhammer 40,000: Dawn of War - Soulstorm",
                Rating = 7,
                Price = 10,
                ReleaseDate = new DateTime(2008, 03, 07),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/3/30/Soulstorm_Coverart.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=Uh9W8QIei8A"
            };
            Game g57 = new Game()
            {
                Title = "Warhammer 40,000: Dawn of War II",
                Rating = 6,
                Price = 10,
                ReleaseDate = new DateTime(2009, 02, 20),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/0/0e/Warhammer_40%2C000_Dawn_of_War_II.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=OTjyO_FncE4"
            };
            Game g58 = new Game()
            {
                Title = "Heroes of Might and Magic II",
                Rating = 4,
                Price = 5,
                ReleaseDate = new DateTime(1996, 10, 01),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/90/Heroes_2_cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=pQIyUl3RL7w"
            };
            Game g59 = new Game()
            {
                Title = "Worms 2",
                Rating = 7,
                Price = 7,
                ReleaseDate = new DateTime(1997, 11, 01),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/Worms2-cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=CxJbWrTlGR0"
            };
            Game g60 = new Game()
            {
                Title = "Worms Armageddon",
                Rating = 9,
                Price = 7,
                ReleaseDate = new DateTime(1999, 11, 30),
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e5/Wa-win-cover.jpg",
                VideoUrl = "https://www.youtube.com/watch?v=Xl2Oox2a58k"
            };
            //Game g61 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g62 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g63 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g64 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g65 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g66 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g67 = new Game()
            //{
            //    Title = "",
            //    Rating = 0,
            //    Price = 0,
            //    ReleaseDate = new DateTime(,,),
            //    PhotoUrl = "",
            //    VideoUrl = ""
            //};
            //Game g68 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};
            //Game g69 = new Game()
            //{ 
            //    Title = "",
            //    Rating = 0, 
            //    Price = 0, 
            //    ReleaseDate = new DateTime(,,), 
            //    PhotoUrl = "", 
            //    VideoUrl = "" 
            //};

            context.Games.AddOrUpdate(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10,
                                      g11, g12, g13, g14, g15, g16, g17, g18, g19, g20,
                                      g21, g22, g23, g24, g25, g26, g27, g28, g29, g30,
                                      g31, g32, g33, g34, g35, g36, g37, g38, g39, g40,
                                      g41, g42, g43, g44, g45, g46, g47, g48, g49, g50,
                                      g51, g52, g53, g54, g55, g56, g57, g58, g59, g60
                                      /*g61, g62, g63, g64, g65, g66, g67, g68, g69*/);
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
            Genre gen12 = new Genre() { Kind = "Sandbox" };
            Genre gen13 = new Genre() { Kind = "Survival" };
            Genre gen14 = new Genre() { Kind = "Shooter" };

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8, gen9, gen10,
                                       gen11, gen12, gen13, gen14);
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
            Company c18 = new Company() { Name = "Bethesda Game Studios", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Bethesda_Game_Studios_logo.svg/1920px-Bethesda_Game_Studios_logo.svg.png" };
            Company c19 = new Company() { Name = "id Software", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c9/Id_Software.svg/800px-Id_Software.svg.png" };
            Company c20 = new Company() { Name = "Interplay Entertainment", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a0/Interplay_Entertainment_logo_colored.png" };
            Company c21 = new Company() { Name = "Bullfrog Productions", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/be/Bullfrog-logo.svg/320px-Bullfrog-logo.svg.png" };
            Company c22 = new Company() { Name = "Lionhead Studios", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/d/dc/Lionhead_Studios_Logo.png" };
            Company c23 = new Company() { Name = "Westwood Studios", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Westwood_Studios_1994.svg/1280px-Westwood_Studios_1994.svg.png" };
            Company c24 = new Company() { Name = "Black Isle Studios", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/9c/Black_Isle_logo%2C_1998.PNG" };
            Company c25 = new Company() { Name = "Firaxis Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Firaxis_Games.svg/800px-Firaxis_Games.svg.png" };
            Company c26 = new Company() { Name = "Rockstar Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/800px-Rockstar_Games_Logo.svg.png" };
            Company c27 = new Company() { Name = "Supergiant Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/59/Supergiant_Games_New_Logo.png" };
            Company c28 = new Company() { Name = "Devolver Digital", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Devolver_Digital_logo.svg/1280px-Devolver_Digital_logo.svg.png" };
            Company c29 = new Company() { Name = "Hasbro Interactive", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/Hasbrointeractive.png" };
            Company c30 = new Company() { Name = "nStigate Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/9/93/NStigate_Games_Logo.jpeg" };
            Company c31 = new Company() { Name = "Troika Games", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Troika_Games_%28logo%29.png" };
            Company c32 = new Company() { Name = "Relic Entertainment", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Relic_Entertainment_logo.svg/1280px-Relic_Entertainment_logo.svg.png" };
            Company c33 = new Company() { Name = "New World Computing", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/5/5f/New_World_Computing_%28logo%29.jpg" };
            Company c34 = new Company() { Name = "Team17", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6a/Team17_logo_%282018%29.svg/1280px-Team17_logo_%282018%29.svg.png" };
            Company c35 = new Company() { Name = "Mojang Studios", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Mojang_Studios_logo_2020.png/1920px-Mojang_Studios_logo_2020.png" };
            Company c36 = new Company() { Name = "Devolver Digital", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Devolver_Digital_logo.svg/1920px-Devolver_Digital_logo.svg.png" };
            Company c37 = new Company() { Name = "Maxis", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/aa/Maxis-logo-2022.svg/327px-Maxis-logo-2022.svg.png?20220322211627" };
            Company c38 = new Company() { Name = "Hasbro Interactive", PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/1/1d/Rct-box.jpg?20171215233650" };

            context.Companies.AddOrUpdate(c1,  c2,  c3,  c4,  c5,  c6,  c7,  c8,  c9,  c10,
                                          c11, c12, c13, c14, c15, c16, c17, c18, c19, c20,
                                          c21, c22, c23, c24, c25, c26, c27, c28, c29, c30,
                                          c31, c32, c33, c34, c35, c36, c37, c38);
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
            g14.Company = c35;
            g15.Company = c1;
            g16.Company = c4;
            g17.Company = c6;
            g18.Company = c15;
            g19.Company = c16;
            g20.Company = c11;
            g21.Company = c17;
            g22.Company = c18;
            g23.Company = c3;
            g24.Company = c5;
            g25.Company = c8;
            g26.Company = c1;
            g27.Company = c19;
            g28.Company = c19;
            g29.Company = c9;
            g30.Company = c10;
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
            g45.Company = c36;
            g46.Company = c1;
            g47.Company = c1;
            g48.Company = c1;
            g49.Company = c37;
            g50.Company = c38;
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
            //g61.Company = c;
            //g62.Company = c;
            //g63.Company = c;
            //g64.Company = c;
            //g65.Company = c;
            //g66.Company = c;
            //g67.Company = c;
            //g68.Company = c;
            //g69.Company = c;

            context.SaveChanges();

            // Adding Genres to Games
            g1.Genres = new List<Genre>() { gen7 };
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
            g14.Genres = new List<Genre>() { gen12 };
            g15.Genres = new List<Genre>() { gen1, gen4 };
            g16.Genres = new List<Genre>() { gen5 };
            g17.Genres = new List<Genre>() { gen4 };
            g18.Genres = new List<Genre>() { gen13 };
            g19.Genres = new List<Genre>() { gen2 };
            g20.Genres = new List<Genre>() { gen9 };
            g21.Genres = new List<Genre>() { gen10, gen14 };
            g22.Genres = new List<Genre>() { gen1, gen4 };
            g23.Genres = new List<Genre>() { gen9 };
            g24.Genres = new List<Genre>() { gen14 };
            g25.Genres = new List<Genre>() { gen11 };
            g26.Genres = new List<Genre>() { gen8 };
            g27.Genres = new List<Genre>() { gen14 };
            g28.Genres = new List<Genre>() { gen14 };
            g29.Genres = new List<Genre>() { gen5 };
            g30.Genres = new List<Genre>() { gen4 };
            g31.Genres = new List<Genre>() { gen5, gen6 };
            g32.Genres = new List<Genre>() { gen5 };
            g33.Genres = new List<Genre>() { gen14 };
            g34.Genres = new List<Genre>() { gen6 };
            g35.Genres = new List<Genre>() { gen4 };
            g36.Genres = new List<Genre>() { gen6 };
            g37.Genres = new List<Genre>() { gen6 };
            g38.Genres = new List<Genre>() { gen6 };
            g39.Genres = new List<Genre>() { gen4 };
            g40.Genres = new List<Genre>() { gen4 };
            g41.Genres = new List<Genre>() { gen4 };
            g42.Genres = new List<Genre>() { gen1, gen2 };
            g43.Genres = new List<Genre>() { gen1, gen2 };
            g44.Genres = new List<Genre>() { gen1, gen4 };
            g45.Genres = new List<Genre>() { gen1, gen2 };
            g46.Genres = new List<Genre>() { gen6 };
            g47.Genres = new List<Genre>() { gen6 };
            g48.Genres = new List<Genre>() { gen6 };
            g49.Genres = new List<Genre>() { gen5 };
            g50.Genres = new List<Genre>() { gen5 };
            g51.Genres = new List<Genre>() { gen4 };
            g52.Genres = new List<Genre>() { gen4 };
            g53.Genres = new List<Genre>() { gen6 };
            g54.Genres = new List<Genre>() { gen6 };
            g55.Genres = new List<Genre>() { gen6 };
            g56.Genres = new List<Genre>() { gen6 };
            g57.Genres = new List<Genre>() { gen6 };
            g58.Genres = new List<Genre>() { gen6 };
            g59.Genres = new List<Genre>() { gen6 };
            g60.Genres = new List<Genre>() { gen6 };
            //g61.Genres = new List<Genre>() { gen };
            //g62.Genres = new List<Genre>() { gen };
            //g63.Genres = new List<Genre>() { gen };
            //g64.Genres = new List<Genre>() { gen };
            //g65.Genres = new List<Genre>() { gen };
            //g66.Genres = new List<Genre>() { gen };
            //g67.Genres = new List<Genre>() { gen };
            //g68.Genres = new List<Genre>() { gen };
            //g69.Genres = new List<Genre>() { gen };

            context.SaveChanges();

            // Adding Games to Companies
            c1.Games = new List<Game>() { g4, g5, g15, g26, g46, g47, g48 };
            c2.Games = new List<Game>() {  };
            c3.Games = new List<Game>() { g23};
            c4.Games = new List<Game>() { g16 };
            c5.Games = new List<Game>() { g24 };
            c6.Games = new List<Game>() { g17 };
            c7.Games = new List<Game>() { g2, g3 };
            c8.Games = new List<Game>() { g25 };
            c9.Games = new List<Game>() { g1, g29 };
            c10.Games = new List<Game>() { g7, g30, g39, g41 };
            c11.Games = new List<Game>() { g8, g20, g33, g40 };
            c12.Games = new List<Game>() { g9 };
            c13.Games = new List<Game>() { g12 };
            c14.Games = new List<Game>() { g13 };
            c15.Games = new List<Game>() { g18 };
            c16.Games = new List<Game>() { g19 };
            c17.Games = new List<Game>() { g21 };
            c18.Games = new List<Game>() { g22 };
            c19.Games = new List<Game>() { g27, g28 };
            c20.Games = new List<Game>() { };
            c21.Games = new List<Game>() { g31 };
            c22.Games = new List<Game>() { g32 };
            c23.Games = new List<Game>() { g34 };
            c24.Games = new List<Game>() { g35 };
            c25.Games = new List<Game>() { g36, g37, g38 };
            c26.Games = new List<Game>() { g42, g43 };
            c27.Games = new List<Game>() { g44 };
            c28.Games = new List<Game>() { };
            c29.Games = new List<Game>() { };
            c30.Games = new List<Game>() { g51 };
            c31.Games = new List<Game>() { g52 };
            c32.Games = new List<Game>() { g53, g54, g55, g56, g57 };
            c33.Games = new List<Game>() { g58 };
            c34.Games = new List<Game>() { g59, g60 };
            c35.Games = new List<Game>() { g14 };
            c36.Games = new List<Game>() { g45 };
            c37.Games = new List<Game>() { g49 };
            c38.Games = new List<Game>() { g50 };


            context.SaveChanges();


            // Adding Games to Genres
            gen1.Games = new List<Game>() { g5, g11, g15, g22, g42, g43, g44, g45 };
            gen2.Games = new List<Game>() { g2, g19, g42, g43, g45 };
            gen3.Games = new List<Game>() { g3 };
            gen4.Games = new List<Game>() { g5, g7, g8, g11, g12, g15, g17, g22, g30, g35, g39, g40, g41, g44, g51, g52 };
            gen5.Games = new List<Game>() { g13, g16, g29, g31, g32, g49, g50 };
            gen6.Games = new List<Game>() { g4, g31, g34, g36, g37, g38, g46, g47, g48, g53, g54, g55, g56, g57, g58, g59, g60 };
            gen7.Games = new List<Game>() { g1 };
            gen8.Games = new List<Game>() { g26 };
            gen9.Games = new List<Game>() { g20 };
            gen10.Games = new List<Game>() { g21, g23 };
            gen11.Games = new List<Game>() { g25 };
            gen12.Games = new List<Game>() { g14 };
            gen13.Games = new List<Game>() { g18, g21 };
            gen14.Games = new List<Game>() { g24, g27, g28, g33 };

            context.SaveChanges();

            #endregion
        }
    }
}

