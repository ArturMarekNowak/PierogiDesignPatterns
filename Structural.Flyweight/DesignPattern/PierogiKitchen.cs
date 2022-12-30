namespace Structural.Flyweight.DesignPattern;

public class PierogiKitchen
{
    private Dictionary<string, Pierogi> _pierogis { get; } = new();

    public PierogiKitchen()
    {
        _pierogis.Add("a", new PierogiWithCabbage(10));
        _pierogis.Add("b", new PierogiWithMeat(10));
        _pierogis.Add("c", new PierogiWithMeat(10));
    }
    public Pierogi GetPierogiPortion(string key)
    {
        return _pierogis[key];
    }
}