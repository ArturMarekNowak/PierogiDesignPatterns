using Behavioral.Visitor.DesignPattern;
using Behavioral.Visitor.Interfaces;

namespace Behavioral.Visitor.Model;

public sealed class PierogiWithPotatoesAndCheese : IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PierogiWithPotatoesAndCheese()
    {
        Guid = Guid.NewGuid();
        Count = 10;
        Type = PierogiType.WithPotatoesAndCheese;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithPotatoesAndCheese(this);
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
        Count = 10;
        Type = PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(this);
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
        Count = 10;
        Type = PierogiType.WithStrawberries;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithStrawberries(this);
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
        Count = 10;
        Type = PierogiType.WithMeat;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithMeat(this);
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
        Count = 10;
        Type = PierogiType.WithGroat;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithGroat(this);
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
        Count = 10;
        Type = PierogiType.WithCabbage;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithCabbage(this);
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
        Count = 10;
        Type = PierogiType.WithBlueberries;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }

    public void AcceptXmlSerializer(PierogiXmlSerializer xmlSerializer)
    {
        xmlSerializer.SerializePierogiWithBlueberries(this);
    }
}