using Behavioral.Visitor.Interfaces;
using Behavioral.Visitor.Model;
using System.Text.Json;


namespace Behavioral.Visitor.DesignPattern;

public class PierogiJsonSerializer : IPierogiSerializer
{
    public void SerializePierogiWithPotatoesAndCheese(PierogiWithPotatoesAndCheese pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(
        PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithStrawberries(PierogiWithStrawberries pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithMeat(PierogiWithMeat pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithGroat(PierogiWithGroat pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithCabbage(PierogiWithCabbage pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }

    public void SerializePierogiWithBlueberries(PierogiWithBlueberries pierogi)
    {
        var pierogiInJson = JsonSerializer.Serialize(pierogi);
        Console.WriteLine(pierogiInJson);
    }
}