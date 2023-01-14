using Behavioral.Visitor.Model;

namespace Behavioral.Visitor.Interfaces;

public interface IPierogiSerializer
{
    public void SerializePierogiWithPotatoesAndCheese(PierogiWithPotatoesAndCheese pierogi);
    public void SerializePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup(PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup pierogi);
    public void SerializePierogiWithStrawberries(PierogiWithStrawberries pierogi);
    public void SerializePierogiWithMeat(PierogiWithMeat pierogi);
    public void SerializePierogiWithGroat(PierogiWithGroat pierogi);
    public void SerializePierogiWithCabbage(PierogiWithCabbage pierogi);
    public void SerializePierogiWithBlueberries(PierogiWithBlueberries pierogi);
}