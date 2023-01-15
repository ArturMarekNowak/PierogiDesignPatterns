using Behavioral.Strategy.DesignPattern;

namespace Behavioral.Strategy;

public class Program
{
    public static void Main()
    {
        var pierogiWithMeatCook = new PierogiWithMeatCook();
        var pierogiWithFruitsCook = new PierogiWithFruitsCook();
        Console.WriteLine(pierogiWithMeatCook.ServePierogi());
        Console.WriteLine(pierogiWithFruitsCook.ServePierogi());
    }
}