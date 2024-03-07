using BurgerRestaurant_ICETASK.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurant_ICETASK.Controllers
{
    public class BurgerController : Controller
    {
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

    }
}
