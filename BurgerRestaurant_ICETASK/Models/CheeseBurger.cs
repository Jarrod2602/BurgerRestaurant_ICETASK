namespace BurgerRestaurant_ICETASK.Models
{
    public class CheeseBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Cheese, Cheese, Cheese, Cheese, Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}
