using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApp.Models;
using FirstWebApp.ViewModels;

namespace FirstWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Dumb Ways To Die" };

            var customers = new List<Customer> { new Customer { Name = "Customer 1" }, new Customer { Name = "Customer 2" } };

            var viewModel = new RandomMovieViewModel() { Movie = movie, Customers = customers }; 
            
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id); 
        }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            //se a pessoa nao der um fator de organização data score etc, da por Nome (ordem alfabetica)
            if(String.IsNullOrEmpty(sortBy) || String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            //just for demo
            return Content(String.Format("pageIndex= {0}&sortBy = {1}", pageIndex, sortBy));
            
        }

        [Route("movies/released/{year:regex(\\d{4}):range(1900,2040)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            //just for demo
            return Content(year + "/" + month);
        }

        [Route("MoviesList")]
        public ActionResult MoviesList()
        {
            var movies = new List<Movie>
            { 
                new Movie { Name = "Star Wars 1", Id = 1 },
                new Movie { Name = "Star Wars 2", Id = 2 }
            };

            var moviesList = new MoviesListViewModel() { Movies = movies };
            //if sont work return a new object view model
            return View(moviesList);
        }
    }
}