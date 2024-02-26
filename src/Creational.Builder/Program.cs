using Creational.Builder.DesignPattern;

namespace Creational.Builder;

sealed class Program
{
    public static void Main()
    {
        var pierogiRestaurant = new PierogiRestaurant();
        var pierogiWithMeatCook = new PierogiWithMeatCook();
        pierogiRestaurant.Serve(pierogiWithMeatCook);
        Console.WriteLine(pierogiWithMeatCook.Cook());
    }
}