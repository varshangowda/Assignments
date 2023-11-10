using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Codebased_test1_b.Controllers
{
    //    public class crudController : Controller
    //    {
    //        // GET: crud
    //        public ActionResult Index()
    //        {
    //            return View();
    //        }
    //    }
    //}



    // MoviesController.cs
    public class MoviesController : Controller
    {
        private MoviesDbContext _context;
        private MoviesDbContext context;

        public MoviesController()
        {
            context = new MoviesDbContext();
        }

        public ActionResult Index()
        {
            var movies = context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                context.Entry(movie).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = _context.Movies.Find(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear(int year)
        {
            var movies = _context.Movies.Where(m => m.DateofRelease.Year == year).ToList();
            return View(movies);
        }
    }


//    // MoviesController.cs
//    public class MoviesController : Controller
//    {
//        private MoviesDbContext _context = new MoviesDbContext();

//        public ActionResult Index()
//        {
//            var movies = _context.Movies.ToList();
//            return View(movies);
//        }

//        public ActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Create(Movie movie)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Movies.Add(movie);
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(movie);
//        }

//        public ActionResult Edit(int id)
//        {
//            var movie = _context.Movies.Find(id);
//            return View(movie);
//        }

//        [HttpPost]
//        public ActionResult Edit(Movie movie)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Entry(movie).State = EntityState.Modified;
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(movie);
//        }

//        public ActionResult Delete(int id)
//        {
//            var movie = _context.Movies.Find(id);
//            return View(movie);
//        }

//        [HttpPost, ActionName("Delete")]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            var movie = _context.Movies.Find(id);
//            _context.Movies.Remove(movie);
//            _context.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        public ActionResult MoviesByYear(int year)
//        {
//            var movies = _context.Movies.Where(m => m.DateofRelease.year == year).ToList();
//            return View(movies);
//        }
//    }
//}
