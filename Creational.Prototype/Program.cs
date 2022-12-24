using Creational.Prototype.DesignPatters;

namespace Creational.Prototype;

class Program
{
    public static void Main()
    {
        var firstPortion = new PierogiWithBlueberries(10);
        Console.WriteLine(firstPortion);
        var secondPortion = firstPortion.Clone();
        Console.WriteLine(secondPortion);
        firstPortion.Count = 5;
        Console.WriteLine(firstPortion);
        Console.WriteLine(secondPortion);

    }
}