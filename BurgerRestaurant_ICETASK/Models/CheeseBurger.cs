namespace BurgerRestaurant_ICETASK.Models
{
    public class CheeseBurger : IBurger
    {
        public string BurgerType { get; set; } = "Cheese";
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Cheese Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }

        public string getImage()
        {
            return "/Burger/Cheese_Burger.jpg";
        }

        public double getPrice()
        {
            return 55.00;
        }



    }
}
