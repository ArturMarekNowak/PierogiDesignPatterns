using Creational.Singleton.DesignPatters;

namespace Creational.Singleton;

class Program
{
    public static async Task Work(int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiSingleton.IsInstanceCreated}");
        await Task.Delay(delay);
        var firstPortionOfPierogi = PierogiSingleton.Instance.ServePierogiWithBlueberries();
        Console.WriteLine($"{firstPortionOfPierogi}, Yummy :D");
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiSingleton.IsInstanceCreated}");
        await Task.Delay(delay);
        var secondPortionOfPierogi = PierogiSingleton.Instance.ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
        Console.WriteLine($"{secondPortionOfPierogi}, aaaah what is this sacrilege? :O");
        await Task.Delay(delay);
    }
    
    public static async Task Main()
    {
        Task.WaitAll(new Task[]
        {
            Task.Run(() => Work(500)),
            Task.Run(() => Work(2500))
        });
    }
}