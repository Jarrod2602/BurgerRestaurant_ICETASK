namespace BurgerRestaurant_ICETASK.Models
{
    public class LowCarbBurger : IBurger
    {
        public string getBun()
        {
            return "Lettuce";
        }

        public string getCondiments()
        {
            return "Mayonaise";
        }

        public string getImage()
        {
            return "/Burger/LowCarb_Burger.jpg";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}
