using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OMDBAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OMDBAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            MovieDAL md = new MovieDAL();
            Movie m = md.GetMovie(title);
            return View(m);
        }

        public IActionResult MovieNight()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieNight(string title, string title2, string title3)
        {
            MovieDAL md = new MovieDAL();
            List<Movie> movieNight = new List<Movie>();
            Movie m = md.GetMovie(title);
            movieNight.Add(m);
            Movie m2 = md.GetMovie(title2);
            movieNight.Add(m2);
            Movie m3 = md.GetMovie(title3);
            movieNight.Add(m3);

            return View(movieNight);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
