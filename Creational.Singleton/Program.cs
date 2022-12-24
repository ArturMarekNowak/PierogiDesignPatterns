using Creational.Singleton.DesignPatters;

namespace Creational.Singleton;

class Program
{
    public static void Main()
    {
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiSingleton.IsInstanceCreated}");
        
        var firstPortionOfPierogi = PierogiSingleton.Instance.ServePierogiWithBlueberries();
        Console.WriteLine($"{firstPortionOfPierogi}, Yummy :D");
        
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiSingleton.IsInstanceCreated}");
        
        var secondPortionOfPierogi = PierogiSingleton.Instance.ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
        Console.WriteLine($"{secondPortionOfPierogi}, aaaah what is this sacrilege? :O");
        
        Console.WriteLine($"Plates of pierogi's served: {PierogiSingleton.Instance.PlatesServed}");
    }
}