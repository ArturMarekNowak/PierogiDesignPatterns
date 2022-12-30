namespace Creational.AbstractFactory.Model;

public abstract class VegeterianDish
{
    protected bool IsOverpriced { get; init; }
}

public class PierogiWithCabbage : VegeterianDish
{
    public Guid Guid { get; }
    public int Count { get; }
    public PierogiTypes Type { get; }

    public PierogiWithCabbage(int count, bool isOvepriced)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithCabbage;
        IsOverpriced = isOvepriced;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}, IsOverpriced: {IsOverpriced}";
    }
}