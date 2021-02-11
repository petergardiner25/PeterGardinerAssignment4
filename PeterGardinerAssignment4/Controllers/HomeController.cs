using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeterGardinerAssignment4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PeterGardinerAssignment4.Controllers
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
            // list our restaruants from restaurant model
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaruants())
            {
                restaurantList.Add(string.Format($"{r.RestaurantRank}. {r.RestaurantName} - Favorite Dish: {r.FavoriteDish} -  Address: {r.Address} - Phone Number: {r.Phone} - Website: {r.Link} "));
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(ApplicationResponse AppResponse)
        {
            //make sure form is valid
            if (ModelState.IsValid)
            {
                Storage.AddApplication(AppResponse);
                return View();
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult SuggestionList(ApplicationResponse AppResponse)
        {
            return View(Storage.Applications);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
