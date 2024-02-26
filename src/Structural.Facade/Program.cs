using Structural.Facade.DesignPattern;
using Structural.Facade.Model;

namespace Structural.Facade;

sealed class Program
{
    public static void Main()
    {
        var pierogiPortion = new PierogiWithMeat(10);
        Console.WriteLine(pierogiPortion);
        var pierogiConverter = new PierogiConverter();
        var newPierogiPortion = pierogiConverter.ConvertPierogiType(pierogiPortion, PierogiType.WithCabbage);
        Console.WriteLine(newPierogiPortion);
    }
}