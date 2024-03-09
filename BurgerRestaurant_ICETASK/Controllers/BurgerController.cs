using BurgerRestaurant_ICETASK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurant_ICETASK.Controllers
{
    public class BurgerController : Controller
    {
        private static List<IBurger> burgerList = new List<IBurger>();
        public IActionResult index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string burgerType)
        {
            BurgerFactory burgerFactory = new BurgerFactory();
            IBurger burger = burgerFactory.getBurger(burgerType);

            return View("Details", burger);
        }

        [HttpPost]
        public IActionResult AddToCart(string burgerType)
        {
            BurgerFactory burgerFactory = new BurgerFactory();
            IBurger burger = burgerFactory.getBurger(burgerType);

            // Add the selected burger to the list
            burgerList.Add(burger);

            return RedirectToAction("Cart");
        }

        public IActionResult Cart()
        {
            BurgerList model = new BurgerList
            {
                Burgers = burgerList
            };

            return View(model);
        }
    }
}
