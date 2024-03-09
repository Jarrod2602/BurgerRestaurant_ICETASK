namespace BurgerRestaurant_ICETASK.Models
{
    public class ChickenBurger : IBurger
    {
        public string BurgerType { get; set; } = "Chicken";
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
        public string getPrice()
        {
            return "R32,00";
        }
    }
}
