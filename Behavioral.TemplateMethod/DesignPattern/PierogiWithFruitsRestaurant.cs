using Behavioral.TemplateMethod.Model;

namespace Behavioral.TemplateMethod.DesignPattern;

public class PierogiWithFruitsRestaurant : PierogiRestaurantAlgorithm
{
    protected override void BuyIngredients()
    {
        Console.WriteLine("Bought fruits");
    }

    protected override void PrepareDishes()
    {
        _pierogi = new Pierogi(10, PierogiType.WithStrawberries);
    }

    protected override Pierogi CookPierogi()
    {
        return _pierogi;
    }
}