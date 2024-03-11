namespace BurgerRestaurant_ICETASK.Models
{
    public class PlainBurger : IBurger
    {
        public string BurgerType { get; set; } = "Plain";
        public string getBun()
        {
            return "Seeded";
        }

        public string getCondiments()
        {
            return "Tomato Sauce";
        }

        public string getImage()
        {
            return "/Burger/Plain_Burger.jpg";
        }

        public string getPatty()
        {
            return "Beef";
        }
        public double getPrice()
        {
            return 69.00;
        }
    }
}
