namespace Structural.Adapter.Model;

public sealed class Pierogi
{
    public Guid Guid { get; }
    public int Count { get; }
    public PierogiType Type { get; set; }

    public Pierogi(int count, PierogiType type)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = type;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}