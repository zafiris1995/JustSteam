using Entities;
using FinalApp.Areas.Customer.ViewModels;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Customer.Controllers
{
    public class CustomerGameController : Controller
    {

        MyDatabase.ApplicationDbContext db = new MyDatabase.ApplicationDbContext();
        UnitOfWork unit;

        public CustomerGameController()
        {
            unit = new UnitOfWork(db);
        }


        public ActionResult HomePage()
        {

            

            GameIndexViewModel givm = new GameIndexViewModel()
            {
                Games = unit.Games.GetAll(),     
                
                GetBestGames = unit.Games.GetBestGames(),
                GetOldestGames = unit.Games.GetOldestGames(),
                GetNewestGames = unit.Games.GetNewestGames(),
                GetGamesByPriceAsc = unit.Games.GetGamesByPriceAsc(),
                GetGamesByPriceDesc = unit.Games.GetGamesByPriceDesc(),
            };

            return View(givm);
        }

     
        public ActionResult ShowAllGames(string genreSearch, string companySearch, string sortOptions )
        {

            var games = unit.Games.GetAll().OrderBy(x => x.Title).ToList();
            IEnumerable<Game> filteredGames = games.ToList();

            //filtering

            if (!string.IsNullOrEmpty(genreSearch))
            {
                filteredGames = filteredGames.Where(x => x.Genres.Select(y => y?.Kind).Contains(genreSearch));
            }

            if (!string.IsNullOrEmpty(companySearch))
            {
                filteredGames = filteredGames.Where(x => x.Company.Name.Contains(genreSearch));
            }


            //sorting 

            switch (sortOptions)
            {
                case "AlphaAsc": filteredGames = filteredGames.OrderBy(x => x.Title).ToList(); break;
                case "NewestAsc": filteredGames = filteredGames.OrderByDescending(x => x.ReleaseDate).ToList(); break;
                case "OldestAsc": filteredGames = filteredGames.OrderBy(x => x.ReleaseDate).ToList(); break;
                case "PriceAsc": filteredGames = filteredGames.OrderBy(x => x.Price).ToList(); break;
                case "PriceDesc": filteredGames = filteredGames.OrderByDescending(x => x.Price).ToList(); break;
                default: filteredGames = filteredGames.OrderBy(x => x.Title).ToList(); break;
            }


            GameIndexViewModel givm = new GameIndexViewModel()
            {
                Games = filteredGames,
                AllGenres = games.SelectMany(x => x.Genres.Select(y => y.Kind != null ? y.Kind : "No Genre")).Distinct().OrderBy(x => x).ToList(),
                AllCompanies = games.Select(y => y.Company.Name != null ? y.Company.Name : "No Company").Distinct().ToList(),
                GetBestGames = unit.Games.GetBestGames()
            };


            return View(givm);
        }

        public ActionResult CustomerGameDetails(int? id)
        {
            

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }

            GameDetailsViewModel gdvm = new GameDetailsViewModel()
            {
                Game = game
            };

            return View(gdvm);

            
        }


        [ChildActionOnly]
        public ActionResult DisplayGameCard(List<Game> games, string headerMessage)
        {
            DisplayGameCard dgc = new DisplayGameCard()
            {
                Games = games,
                HeaderTitle = headerMessage
            };
            return View(dgc);
        }


        //public ActionResult DisplayAllGames()
        //{
        //    return ();
        //}
        

    }
}