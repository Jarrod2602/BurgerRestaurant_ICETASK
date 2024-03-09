namespace BurgerRestaurant_ICETASK.Models
{
    public interface IBurger
    {
        string BurgerType { get; set; }
        string getBun();
        string getPatty();
        string getCondiments();
        string getImage();
        string getPrice();

    }
    
}
