using Structural.Bridge.Interfaces;

namespace Structural.Bridge.Model;

public sealed class PierogiWithPotatoesAndCheese : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithPotatoesAndCheese()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithPotatoesAndCheese;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithStrawberries : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithStrawberries()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithStrawberries;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithMeat : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithMeat()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithMeat;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithGroat : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithGroat()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithGroat;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithCabbage : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithCabbage()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithCabbage;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithBlueberries : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithBlueberries()
    {
        Guid = Guid.NewGuid();
        Type = PierogiType.WithBlueberries;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}