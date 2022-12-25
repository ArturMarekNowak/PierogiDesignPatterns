namespace Creational.Singleton.Model;

public sealed class Pierogi
{
    public Guid Guid { get; }
    public int Count { get; }
    public PierogiTypes Type { get; }

    public Pierogi(int count, PierogiTypes type)
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