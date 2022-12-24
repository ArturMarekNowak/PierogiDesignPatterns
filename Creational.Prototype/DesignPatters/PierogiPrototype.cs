using Creational.Prototype.Model;

namespace Creational.Prototype.DesignPatters;

public abstract class PierogiPrototype
{
    public Guid Guid { get; }
    public int Count { set; get; }
    public string Type { get; set; }
    
    public PierogiPrototype(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
    }
    
    public abstract PierogiPrototype Clone();
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public class PierogiWithPotatoesAndCheese : PierogiPrototype
{
    public PierogiWithPotatoesAndCheese(int count) : base(count)
    {
        Type = PierogiTypes.WithPotatoesAndCheese;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup : PierogiPrototype
{
    public PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(int count) : base(count)
    {
        Type = PierogiTypes.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithStrawberries : PierogiPrototype
{
    public PierogiWithStrawberries(int count) : base(count)
    {
        Type = PierogiTypes.WithStrawberries;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithMeat : PierogiPrototype
{
    public PierogiWithMeat(int count) : base(count)
    {
        Type = PierogiTypes.WithMeat;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithGroat : PierogiPrototype
{
    public PierogiWithGroat(int count) : base(count)
    {
        Type = PierogiTypes.WithGroat;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithCabbage : PierogiPrototype
{
    public PierogiWithCabbage(int count) : base(count)
    {
        Type = PierogiTypes.WithCabbage;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}

public class PierogiWithBlueberries : PierogiPrototype
{
    public PierogiWithBlueberries(int count) : base(count)
    {
        Type = PierogiTypes.WithBlueberries;
    }

    public override PierogiPrototype Clone()
    {
        return (PierogiPrototype)MemberwiseClone();
    }
}