using Behavioral.State.DesignPattern;

public class Program
{
    public static void Main()
    {
        var pierogiKitchen = new PierogiKitchen(new Undercooked());
        
        pierogiKitchen.Request();
        pierogiKitchen.Request();
        pierogiKitchen.Request();
    }
}