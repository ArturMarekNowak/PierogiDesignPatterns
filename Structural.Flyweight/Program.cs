using Structural.Flyweight.DesignPattern;

namespace Structural.Flyweight;

sealed class Program
{
    public static void Main()
    {
        var pierogiKitchen = new PierogiKitchen();
        
        var firstPortion = pierogiKitchen.GetPierogiPortion("a");
        firstPortion.AskForSeconds(5);
        Console.WriteLine(firstPortion);
        
        var secondPortion = pierogiKitchen.GetPierogiPortion("b");
        secondPortion.AskForSeconds(10);
        Console.WriteLine(secondPortion);
        
        var thirdPortion = pierogiKitchen.GetPierogiPortion("c");
        thirdPortion.AskForSeconds(15);
        Console.WriteLine(thirdPortion);
    }
}