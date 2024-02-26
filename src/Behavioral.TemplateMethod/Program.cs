using Behavioral.TemplateMethod.DesignPattern;

namespace Behavioral.TemplateMethod;

class Program
{
    public static void Main()
    {
        var pierogiWithMeatRestaurant = new PierogiWithMeatRestaurant();
        Console.WriteLine(pierogiWithMeatRestaurant.ServePierogi());
        var pierogiWithFruitsRestaurant = new PierogiWithFruitsRestaurant();
        Console.WriteLine(pierogiWithFruitsRestaurant.ServePierogi());
    }
}