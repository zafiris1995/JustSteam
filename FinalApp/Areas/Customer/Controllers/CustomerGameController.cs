using Entities;
using FinalApp.Areas.Customer.ViewModels;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
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


        // GET: Customer/CustomerGame
        public ActionResult Index()
        {
            

            GameIndexViewModel givm = new GameIndexViewModel()
            {
                Games = unit.Games.GetAll(),
                //GetBestGames = unit.Games.GetBestGames()
            };          

            return View(givm);
        }


        public ActionResult CustomerGameDetails()
        {


            return View();
        }



        public ActionResult DisplayGameCard(List<Game> games, string headerMessage)
        {
            DisplayGameCard dgc = new DisplayGameCard()
            {
                Games = games,
                HeaderTitle = headerMessage
            };
            return View(dgc);
        }

    }
}