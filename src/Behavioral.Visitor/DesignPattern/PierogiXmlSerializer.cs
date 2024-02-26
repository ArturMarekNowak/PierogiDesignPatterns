using System.Xml.Serialization;
using Behavioral.Visitor.Interfaces;
using Behavioral.Visitor.Model;

namespace Behavioral.Visitor.DesignPattern;

public class PierogiXmlSerializer : IPierogiSerializer
{
    public void SerializePierogiWithPotatoesAndCheese(PierogiWithPotatoesAndCheese pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithPotatoesAndCheese));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(
        PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithStrawberries(PierogiWithStrawberries pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithStrawberries));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithMeat(PierogiWithMeat pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithMeat));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithGroat(PierogiWithGroat pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithGroat));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithCabbage(PierogiWithCabbage pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithCabbage));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }

    public void SerializePierogiWithBlueberries(PierogiWithBlueberries pierogi)
    {
        var xmlSerializer = new XmlSerializer(typeof(PierogiWithBlueberries));
        xmlSerializer.Serialize(Console.Out, pierogi);
    }
}