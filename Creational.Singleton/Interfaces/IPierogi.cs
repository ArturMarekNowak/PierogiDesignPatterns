using Creational.Singleton.Model;

namespace Creational.Singleton.Interfaces;

public interface IPierogi
{
    public Pierogi ServePierogiWithPotatoesAndCheese();
    public Pierogi ServePierogiWithGroat();
    public Pierogi ServePierogiWithCabbage();
    public Pierogi ServePierogiWithMeat();
    public Pierogi ServePierogiWithStrawberries();
    public Pierogi ServePierogiWithBlueberries();
    public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
}