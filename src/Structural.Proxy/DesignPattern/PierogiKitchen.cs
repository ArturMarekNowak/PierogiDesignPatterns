using Structural.Proxy.Interfaces;
using Structural.Proxy.Model;

namespace Structural.Proxy.DesignPattern;

public class PierogiKitchen : IPierogiService
{
    public Pierogi ServePierogiWithPotatoesAndCheese()
    {
        return new Pierogi(10, PierogiType.WithPotatoesAndCheese);
    }

    public Pierogi ServePierogiWithGroat()
    {
        return new Pierogi(10, PierogiType.WithGroat);
    }

    public Pierogi ServePierogiWithCabbage()
    {
        return new Pierogi(10, PierogiType.WithCabbage);
    }

    public Pierogi ServePierogiWithMeat()
    {
        return new Pierogi(10, PierogiType.WithMeat);
    }

    public Pierogi ServePierogiWithStrawberries()
    {
        return new Pierogi(10, PierogiType.WithStrawberries);
    }

    public Pierogi ServePierogiWithBlueberries()
    {
        return new Pierogi(10, PierogiType.WithBlueberries);
    }

    public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup()
    {
        return new Pierogi(10, PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup);
    }
}