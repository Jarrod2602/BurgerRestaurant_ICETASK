﻿namespace BurgerRestaurant_ICETASK.Models
{
    public class FishBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Tartar Sauce";
        }

        public string getImage()
        {
            return "/Burger/Fish_Burger.jpg";
        }

        public string getPatty()
        {
            return "Fish";
        }
    }
}
