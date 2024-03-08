namespace BurgerRestaurant_ICETASK.Models
{
    public class PlainBurger : IBurger
    {
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
        public string getPrice()
        {
            return "R69,00";
        }
    }
}
