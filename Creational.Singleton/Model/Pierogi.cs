namespace Creational.Singleton.Model;

public sealed class Pierogi
{
    public Guid Guid { get; }
    public int Count { get; }
    public string Type { get; }
    
    public Pierogi(Guid guid, int count, string type)
    {
        Guid = guid;
        Count = count;
        Type = type;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}