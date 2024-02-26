using Creational.Singleton.Interfaces;
using Creational.Singleton.Model;

namespace Creational.Singleton.DesignPattern;

public sealed class PierogiRestaurant : IPierogi
{
    private static readonly Lazy<PierogiRestaurant> LazyInstance = new(() => new PierogiRestaurant());

    public static PierogiRestaurant Instance => LazyInstance.Value;
    public static bool IsInstanceCreated => LazyInstance.IsValueCreated;
    public int PlatesServed = 0;

    private PierogiRestaurant()
    {
    }

    public Pierogi ServePierogiWithPotatoesAndCheese()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithPotatoesAndCheese);
    }

    public Pierogi ServePierogiWithGroat()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithGroat);
    }

    public Pierogi ServePierogiWithCabbage()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithCabbage);
    }

    public Pierogi ServePierogiWithMeat()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithMeat);
    }

    public Pierogi ServePierogiWithStrawberries()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithStrawberries);
    }

    public Pierogi ServePierogiWithBlueberries()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithBlueberries);
    }

    public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup()
    {
        PlatesServed += 1;
        return new Pierogi(10, PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup);
    }
}