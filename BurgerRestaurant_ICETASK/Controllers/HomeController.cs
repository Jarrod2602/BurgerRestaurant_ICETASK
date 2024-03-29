﻿using BurgerRestaurant_ICETASK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerRestaurant_ICETASK.Controllers
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
            var burgerTypes = new List<string> { "Chicken", "Cheese" };
            return View(burgerTypes);
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