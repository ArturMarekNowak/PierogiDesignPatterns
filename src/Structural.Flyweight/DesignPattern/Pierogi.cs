using Structural.Flyweight.Model;

namespace Structural.Flyweight.DesignPattern;

public abstract class Pierogi
{
    public Guid Guid { get; init; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }

    public abstract void AskForSeconds (int secondsCount);
}

public class PierogiWithMeat : Pierogi
{
    public PierogiWithMeat(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiType.WithMeat;
    }

    public override void AskForSeconds(int secondsCount)
    {
        Count += secondsCount;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public class PierogiWithCabbage : Pierogi
{
    public PierogiWithCabbage(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiType.WithCabbage;
    }
    
    public override void AskForSeconds(int secondsCount)
    {
        Count += secondsCount;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}