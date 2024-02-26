using Behavioral.Strategy.Model;

namespace Behavioral.Strategy.DesignPattern;

public class PierogiWithFruitsCook : IPierogiCookingStrategy
{
    public Pierogi ServePierogi()
    {
        return new Pierogi(10, PierogiType.WithStrawberries);
    }
}