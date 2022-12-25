using Creational.Prototype.Model;

namespace Creational.Prototype.DesignPatters;

public interface IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiTypes Type { get; set; }

    public abstract IPierogiPrototype Clone();
    public string ToString();
}

public sealed class PierogiWithPotatoesAndCheese : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithPotatoesAndCheese(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithPotatoesAndCheese;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithStrawberries : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithStrawberries(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithStrawberries;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithMeat : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithMeat(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithMeat;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithGroat : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithGroat(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithGroat;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithCabbage : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithCabbage(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithCabbage;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithBlueberries : IPierogiPrototype
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiTypes Type { get; set; }
    
    public PierogiWithBlueberries(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithBlueberries;
    }

    public IPierogiPrototype Clone()
    {
        return (IPierogiPrototype)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}