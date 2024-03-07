namespace BurgerRestaurant_ICETASK.Models
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "French Bread";
        }

        public string getCondiments()
        {
            return "Sweet Chilli Sauce";
        }

        public string getPatty()
        {
            return "Chicken";
        }

        public string getImage()
        {
            return "/Burger/Chicken_Burger.jpg";
        }
    }
}
