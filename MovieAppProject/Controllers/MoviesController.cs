using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieAppProject.Models;
using System.Data.Entity;
using MovieAppProject.ViewModels;

namespace MovieAppProject.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies/NewMovie
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);

        }

        public ActionResult Details(int id)
        {
            var MovDet = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (MovDet == null) { return HttpNotFound(); }
            return View(MovDet);
        }
    }
}