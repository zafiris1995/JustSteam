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
                GetBestGames = unit.Games.GetBestGames()
            };

            return View(givm);
        }

     
        public ActionResult ShowAllGames()
        {
            GameIndexViewModel givm = new GameIndexViewModel()
            {
                Games = unit.Games.GetAll(),
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