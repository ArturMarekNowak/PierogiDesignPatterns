using Creational.Builder.DesignPattern;

namespace Creational.Builder;

sealed class Program
{
    public static void Main()
    {
        var pierogiRestaurant = new PierogiRestaurant();
        var pierogiWithMeatBuilder = new PierogiWithMeatCook();
        pierogiRestaurant.Serve(pierogiWithMeatBuilder);
        Console.WriteLine(pierogiWithMeatBuilder.Cook());
    }
}