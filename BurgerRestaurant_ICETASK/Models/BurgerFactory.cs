namespace BurgerRestaurant_ICETASK.Models
{
    public class BurgerFactory
    {
        public IBurger returnInstance;
        public IBurger getBurger(string BurgerType)
        {

            if (BurgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (BurgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            return returnInstance;
        }
    }
}
