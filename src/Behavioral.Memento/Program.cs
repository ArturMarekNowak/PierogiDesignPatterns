using Behavioral.Memento.DesignPattern;
using Behavioral.Memento.Model;

public class Program
{
    public static void Main()
    {
        var pierogiKitchen = new PierogiKitchen();
        var pierogiOriginator = new PierogiOriginator();

        pierogiOriginator.pierogiState = new Pierogi(100, PierogiType.WithPotatoesAndCheese);
        pierogiKitchen.PierogiMemento = pierogiOriginator.CreateMemento();
        pierogiOriginator.pierogiState = new Pierogi(10, PierogiType.WithPotatoesAndCheese);
        pierogiOriginator.SetMemento(pierogiKitchen.PierogiMemento);
    }
}