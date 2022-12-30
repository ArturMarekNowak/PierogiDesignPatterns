using Structural.Proxy.Model;

namespace Structural.Proxy.Interfaces;

public interface IPierogiService
{
    public Pierogi ServePierogiWithPotatoesAndCheese();
    public Pierogi ServePierogiWithGroat();
    public Pierogi ServePierogiWithCabbage();
    public Pierogi ServePierogiWithMeat();
    public Pierogi ServePierogiWithStrawberries();
    public Pierogi ServePierogiWithBlueberries();
    public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
}