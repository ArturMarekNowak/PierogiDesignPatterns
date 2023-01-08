using Structural.Bridge.DesignPattern;
using Structural.Bridge.Model;

namespace Structural.Bridge;

class Program
{
    public static void Main()
    {
        var pierogiWithBlueberries = new PierogiWithBlueberries();
        var bigPierogiRestaurant = new BigPierogiRestaurant(pierogiWithBlueberries);
        Console.WriteLine(bigPierogiRestaurant.ServePierogi());
        
        var pierogiWithStrawberries = new PierogiWithStrawberries();
        bigPierogiRestaurant = new BigPierogiRestaurant(pierogiWithStrawberries);
        Console.WriteLine(bigPierogiRestaurant.ServePierogi());

        var pierogiRestaurant = new PierogiRestaurant(pierogiWithStrawberries);
        Console.WriteLine(pierogiRestaurant.ServePierogi());
        
    }
}