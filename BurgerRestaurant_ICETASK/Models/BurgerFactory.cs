﻿namespace BurgerRestaurant_ICETASK.Models
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
            else if(BurgerType.ToLower().Equals("plain"))
            {
                returnInstance = new PlainBurger();
            }
            else if(BurgerType.ToLower().Equals("veggie"))
            {
                returnInstance = new VeggiBurger();
            }
            else if(BurgerType.ToLower().Equals("lowcarb"))
            {
                returnInstance = new LowCarbBurger();
            }
            else if(BurgerType.ToLower().Equals("fish"))
            {
                returnInstance = new FishBurger();
            }
            return returnInstance;
        }
    }
}
