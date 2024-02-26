using Behavioral.Strategy.Model;

namespace Behavioral.Strategy.DesignPattern;

public class PierogiWithMeatCook : IPierogiCookingStrategy
{
    public Pierogi ServePierogi()
    {
        return new Pierogi(10, PierogiType.WithMeat);
    }
}