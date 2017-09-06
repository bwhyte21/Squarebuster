using Squarebuster.Models;
using Squarebuster.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Squarebuster.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "The Mask" },
                new Movie { Id = 2, Name = "The 40 Year Old Virgin" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };
            // init movie prop and customers prop
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

     
    }
}