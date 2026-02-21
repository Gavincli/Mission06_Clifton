using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using Mission06_Clifton.Models;

namespace Mission06_Clifton.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;

        public HomeController(MoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            _context.Movies.Add(response); // Add record to database
            _context.SaveChanges();
            return View("Confirmation");
        }

        // NEW ACTION: Display all movies
        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList(); // Fetch all movies
            return View(movies);                   // Pass to view
        }

        // GET: show the form with existing data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: submit the changes
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View(movie);
        }

        // GET: Confirm delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: actually delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("MovieList");
        }
    }
}