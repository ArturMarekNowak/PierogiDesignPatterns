using Structural.Adapter.DesignPattern;
using Structural.Adapter.Model;

namespace Structural.Adapter;

public class Program
{
    public static void Main()
    {
        var pierogi = new Pierogi(10, PierogiType.WithMeat);
        var pierogiRestaurant = new PierogiWithFruitsRestaurant(pierogi);
        Console.WriteLine(pierogiRestaurant.ServePierogi());
    }
}