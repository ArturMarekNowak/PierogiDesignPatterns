using Creational.Prototype.Model;

namespace Creational.Prototype.DesignPatters;

public abstract class PierogiPrototype
{
    public PierogiPrototype(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
    }

    public Guid Guid { get; }
    public int Count { set; get; }
    public PierogiTypes Type { get; set; }

    public abstract PierogiPrototype Clone();

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
}

public sealed class PierogiWithPotatoesAndCheese : PierogiPrototype
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

public sealed class PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup : PierogiPrototype
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

public sealed class PierogiWithStrawberries : PierogiPrototype
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

public sealed class PierogiWithMeat : PierogiPrototype
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

public sealed class PierogiWithGroat : PierogiPrototype
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

public sealed class PierogiWithCabbage : PierogiPrototype
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

public sealed class PierogiWithBlueberries : PierogiPrototype
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