namespace Creational.Builder.Model;

public sealed class Pierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }

    public Pierogi()
    {
        Guid = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}