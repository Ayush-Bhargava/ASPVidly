using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };
            List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "Kenna Dahlgren"},
                new Customer {Name = "Dylan Sheats"},
                new Customer {Name = "Veola Then"},
                new Customer {Name = "Wyatt Everly"},
                new Customer {Name = "Lyndsey Uchida"},
                new Customer {Name = "Leonardo Folkerts"},
            };

            RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year:regex(^\\d{4}$)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

        public ActionResult Movies()
        {
            MoviesViewModel movies = new MoviesViewModel();
            movies.Movies = new List<Movie>
            {
                new Movie {ID = 1, Name = "Pulp Fiction"},
                new Movie {ID = 2, Name = "Schindler’s List"},
                new Movie {ID = 3, Name = "12 Angry Men"},
                new Movie {ID = 4, Name = "Gone With The Wind"},
                new Movie {ID = 5, Name = "Shawshank Redemption"},
                new Movie {ID = 6, Name = "The Godfather"},
                new Movie {ID = 7, Name = "Citizen Kane"},
                new Movie {ID = 8, Name = "The Matrix"},
                new Movie {ID = 9, Name = "Avengers"},
                new Movie {ID = 10, Name = "Fight Club"}
            };
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            MoviesViewModel movies = new MoviesViewModel();
        movies.Movies = new List<Movie>
            {
                new Movie {ID = 1, Name = "Pulp Fiction"},
                new Movie {ID = 2, Name = "Schindler’s List"},
                new Movie {ID = 3, Name = "12 Angry Men"},
                new Movie {ID = 4, Name = "Gone With The Wind"},
                new Movie {ID = 5, Name = "Shawshank Redemption"},
                new Movie {ID = 6, Name = "The Godfather"},
                new Movie {ID = 7, Name = "Citizen Kane"},
                new Movie {ID = 8, Name = "The Matrix"},
                new Movie {ID = 9, Name = "Avengers"},
                new Movie {ID = 10, Name = "Fight Club"}
            };

            Movie movie = movies.Movies.Where(t => t.ID == id).FirstOrDefault();
            if (movie!=null)
            {
                return View(movie);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}