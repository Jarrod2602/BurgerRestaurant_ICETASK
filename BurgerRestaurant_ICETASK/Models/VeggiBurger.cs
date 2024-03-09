namespace BurgerRestaurant_ICETASK.Models
{
    public class VeggiBurger : IBurger
    {
        public string BurgerType { get; set; } = "Veggie";
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "BBQ Sauce";
        }

        public string getImage()
        {
            return "/Burger/Veggi_Burger.jpg";
        }

        public string getPatty()
        {
            return "Vegeterian";
        }
        public string getPrice()
        {
            return "R45,00";
        }
    }
}
