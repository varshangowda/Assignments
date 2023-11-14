using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using new_crud.Models;


namespace new_crud.Controllers
{
    public class MVController : Controller
    {
        // GET: MV
        public moviecontext _context = new moviecontext();
        public ActionResult Index()
        {
            var movies = _context.mov.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(movie movie)
        {
            _context.mov.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = _context.mov.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(movie movie)
        {
            _context.mov.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var movie = _context.mov.Find(id);
            _context.mov.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}