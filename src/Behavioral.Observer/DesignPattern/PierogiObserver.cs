namespace Behavioral.Observer.DesignPattern;

public class PierogiObserver : IPierogiObserver
{
    public string Name { get; init; }
    
    public PierogiObserver(string name)
    {
        Name = name;
    }
    
    public void Update(IPierogiWarehouse pierogiWarehouse)
    {
        Console.WriteLine(pierogiWarehouse.NumberOfPierogi < 100
            ? $"{Name}: Oh no we are running low on pierogi! PANIC NOW"
            : $"{Name}: Gooood, gooooooooood, let pierogi flow through you!");
    }
}