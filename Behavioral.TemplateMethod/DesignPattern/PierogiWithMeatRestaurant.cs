using Behavioral.TemplateMethod.Model;

namespace Behavioral.TemplateMethod.DesignPattern;

public class PierogiWithMeatRestaurant : PierogiRestaurantAlgorithm
{
    protected override void BuyIngredients()
    {
        Console.WriteLine("Bought meat");
    }

    protected override void PrepareDishes()
    {
        _pierogi = new Pierogi(10, PierogiType.WithMeat);
    }

    protected override Pierogi CookPierogi()
    { 
        return _pierogi;
    }
}