namespace Behavioral.Command.DesignPattern;

public sealed class Compliment : ICommand
{
    private readonly IReceiver _receiver;
    
    public Compliment(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        Console.WriteLine("Passing a compliment");
        _receiver.Respond(this);
    }
}