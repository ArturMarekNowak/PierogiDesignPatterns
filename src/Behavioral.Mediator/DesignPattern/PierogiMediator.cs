namespace Behavioral.Mediator.DesignPattern;

public class PierogiMediator : IPierogiMediator
{
    private PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman _pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman;
    private PierogiWithPotatoesAndCheeseGentleman _pierogiWithPotatoesAndCheeseGentleman;
        
    public PierogiMediator(PierogiWithPotatoesAndCheeseGentleman pierogiWithPotatoesAndCheeseGentleman,
        PierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman)
    {
        _pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman = pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman;
        _pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman.PierogiMediator = this;
            
        _pierogiWithPotatoesAndCheeseGentleman = pierogiWithPotatoesAndCheeseGentleman;
        _pierogiWithPotatoesAndCheeseGentleman.PierogiMediator = this;

    }

    public void Send(string message, IPierogiGentleman gentleman)
    {
        if (gentleman == _pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman)
            _pierogiWithPotatoesAndCheeseGentleman.Notify(message);
            
        if (gentleman == _pierogiWithPotatoesAndCheeseGentleman)
            _pierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchupGentleman.Notify(message);
    }
}