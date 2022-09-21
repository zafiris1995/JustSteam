using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;
using FinalApp.Areas.Admin.ViewModels;
using MyDatabase;
using RepositoryServices.Persistance;

namespace FinalApp.Areas.Admin.Controllers
{
    public class AdminGameController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        UnitOfWork unit;

        public AdminGameController()
        {
            unit = new UnitOfWork(db);
        }



        // GET: Admin/AdminGame
        public ActionResult Index()
        {

            AdminIndexViewModel aivm = new AdminIndexViewModel()
            {
                Games = unit.Games.GetAll().ToList(),
                AllGenres = db.Games.SelectMany(x => x.Genres.Select(y => y.Kind != null ? y.Kind : "No Genre")).Distinct().OrderBy(x => x).ToList(),
            };


            return View(aivm);
        }

        // GET: Admin/AdminGame/Details
        public ActionResult Details(int? id)
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
            return View(game);
        }

        // GET: Admin/AdminGame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminGame/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // GET: Admin/AdminGame/Edit
        public ActionResult Edit(int? id)
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
            return View(game);
        }

        // POST: Admin/AdminGame/Edit
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Price,Rating")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Admin/AdminGame/Delete
        public ActionResult Delete(int? id)
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
            return View(game);
        }

        // POST: Admin/AdminGame/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
