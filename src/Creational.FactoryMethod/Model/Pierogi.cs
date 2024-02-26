﻿using Creational.Factory.Interfaces;

namespace Creational.Factory.Model;

public sealed class PierogiWithPotatoesAndCheese : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithPotatoesAndCheese(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithStrawberries(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithMeat(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithGroat(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithCabbage(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
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
    
    public PierogiWithBlueberries(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiType.WithBlueberries;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}