using Behavioral.Mediator.Model;

namespace Behavioral.Mediator.DesignPattern;

public class PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman : IPierogiGentleman
{
    public IPierogiMediator PierogiMediator { get; set; }
    public Pierogi Pierogi { get; set; }

    public PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman()
    {
        Pierogi = new Pierogi(10, PierogiType.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup);
    }
        
    public void Send(string message)
    {
        PierogiMediator.Send(message, this);
    }
        
    public void Notify(string message)
    {
        Console.WriteLine($"{typeof(PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman)} gets message: " + message);
    }
}
    
public class PierogiWithPotatoesAndCheeseGentleman : IPierogiGentleman
{
    public IPierogiMediator PierogiMediator { get; set; }
    public Pierogi Pierogi { get; set; }
        
    public PierogiWithPotatoesAndCheeseGentleman()
    {
        Pierogi = new Pierogi(10, PierogiType.WithPotatoesAndCheese);
    }
        
    public void Send(string message)
    {
        PierogiMediator.Send(message, this);
    }
        
    public void Notify(string message)
    {
        Console.WriteLine($"{typeof(PierogiWithPotatoesAndCheeseGentleman)} gets message: " + message);
    }
}
