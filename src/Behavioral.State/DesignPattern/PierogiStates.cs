namespace Behavioral.State.DesignPattern;

public class Undercooked : IPierogiState
{
    public void Handle(PierogiKitchen pierogiKitchen)
    {
        Console.WriteLine("Oh no pierogi are undercooked :c");
        pierogiKitchen.State = new Perfect();
    }
}

public class Perfect : IPierogiState
{
    public void Handle(PierogiKitchen pierogiKitchen)
    {
        Console.WriteLine("Pierogi are perfect! Turn off the stove!");
        pierogiKitchen.State = new Overcooked();
    }
}

public class Overcooked  : IPierogiState
{
    public void Handle(PierogiKitchen pierogiKitchen)
    {
        Console.WriteLine("Oh no pierogi are overcooked :c");
    }
}