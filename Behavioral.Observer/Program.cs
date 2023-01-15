using Behavioral.Observer.DesignPattern;

namespace Behavioral.Observer;

public class Program
{
    public static void Main()
    {
        var pierogiObserverJohn = new PierogiObserver("John");
        var pierogiObserverAndrew = new PierogiObserver("Andrew");
        var pierogiWarehouse = new PierogiWarehouse();
        
        pierogiWarehouse.Attach(pierogiObserverJohn);
        pierogiWarehouse.Attach(pierogiObserverAndrew);
        
        pierogiWarehouse.SetPierogiCount(101);
        
        pierogiWarehouse.Detach(pierogiObserverJohn);
        
        pierogiWarehouse.SetPierogiCount(99);
    }
}
