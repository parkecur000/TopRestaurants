using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurants.Models;

namespace TopRestaurants.Controllers
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
            List<string> RestaurantList = new List<string>();

            foreach (Top5 r in Top5.GetRestaurant())
            {
                //Below is where I create an array of string objects with the Top5 restaurants to the index page.
                RestaurantList.Add($"#{r.rank}: {r.name} <br>Favorite dish: {r.fav_dish} <br>Address: {r.address} <br>Phone Number: {r.phone} <br>Link: <a href=\"{r.link}\">{r.link}</a>");
                
            }
            return View(RestaurantList);
        }
        [HttpGet]
        public IActionResult Submissions()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submissions(Submissions appResponse)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                TempStorage.AddSubmission(appResponse);
                return View("DisplaySubmissions", TempStorage.Submissions);
            }
        }
        public IActionResult DisplaySubmissions()
        {
            return View(TempStorage.Submissions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
