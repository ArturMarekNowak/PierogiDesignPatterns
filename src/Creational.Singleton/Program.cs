using Creational.Singleton.DesignPattern;

namespace Creational.Singleton;

sealed class Program
{
    private static async Task Work(int delay)
    {
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiRestaurant.IsInstanceCreated}");
        await Task.Delay(delay);
        var firstPortionOfPierogi = PierogiRestaurant.Instance.ServePierogiWithBlueberries();
        Console.WriteLine($"{firstPortionOfPierogi}, Yummy :D");
        Console.WriteLine($"Is pierogi singleton instantiated: {PierogiRestaurant.IsInstanceCreated}");
        await Task.Delay(delay);
        var secondPortionOfPierogi = PierogiRestaurant.Instance.ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
        Console.WriteLine($"{secondPortionOfPierogi}, aaaah what is this sacrilege? :O");
        Console.WriteLine($"Plates served: {PierogiRestaurant.Instance.PlatesServed}");
    }
    
    public static Task Main()
    {
        Task.WaitAll(new Task[]
        {
            Task.Run(() => Work(500)),
            Task.Run(() => Work(2500))
        });
        return Task.CompletedTask;
    }
}