using FinalApp.Models;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Controllers
{
    public class HomeController : Controller
    {
        MyDatabase.ApplicationDbContext db = new MyDatabase.ApplicationDbContext();
        UnitOfWork unit;

        public HomeController()
        {
            unit = new UnitOfWork(db);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}