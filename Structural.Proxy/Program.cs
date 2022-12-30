using Structural.Proxy.DesignPattern;
using Structural.Proxy.Model;

namespace Structural.Proxy;

sealed class Program
{
    public static void Main()
    {
        var pierogiWaitress = new PierogiWaitress();
        try
        {
            pierogiWaitress.SetClientsAge(17);
            Console.WriteLine(pierogiWaitress.ServePierogiWithPotatoesAndCheese());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        pierogiWaitress.SetClientsAge(19);
        Console.WriteLine(pierogiWaitress.ServePierogiWithPotatoesAndCheese());
    }
}