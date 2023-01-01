using Structural.Facade.Interfaces;
using Structural.Facade.Model;

namespace Structural.Facade.DesignPattern;

public class PierogiConverter
{
    public IPierogi ConvertPierogiType(IPierogi pierogi, PierogiType desiredPierogiType)
    {
        if (desiredPierogiType == pierogi.Type) Console.WriteLine("Pierogi type is already set to the desired type!");

        switch (desiredPierogiType)
        {
            case PierogiType.WithBlueberries:
               return new PierogiWithBlueberries(pierogi);
                
            case PierogiType.WithStrawberries:
               return new PierogiWithBlueberries(pierogi);
                
            case PierogiType.WithCabbage:
               return new PierogiWithBlueberries(pierogi);
                
            case PierogiType.WithGroat:
               return new PierogiWithBlueberries(pierogi);
                
            case PierogiType.WithMeat:
               return new PierogiWithBlueberries(pierogi);
            
            case PierogiType.WithPotatoesAndCheese:
                return new PierogiWithBlueberries(pierogi);
            
            case PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup:
                return new PierogiWithBlueberries(pierogi);
            
            default:
                throw new ArgumentOutOfRangeException(nameof(desiredPierogiType), desiredPierogiType, null);
        }
    }
}