namespace Behavioral.Command.DesignPattern;

public sealed class BuyPierogi : ICommand
{
    private readonly IReceiver _receiver;
        
    public BuyPierogi(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        Console.WriteLine("Placing an order...");
        _receiver.Respond(this);
    }
}