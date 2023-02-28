using Behavioral.Command.Model;

namespace Behavioral.Command.DesignPattern;

public sealed class Cook : IReceiver
{
    public void Respond(ICommand command)
    {
        switch (command)
        {
            case BuyPierogi: 
                Console.WriteLine($"Delicious {new Pierogi(10, PierogiType.WithPotatoesAndCheese)} for you sir!");
                break;
                
            case Compliment:
                Console.WriteLine("Oh stop it you! I am blushing ^^");
                break;
        }
    }
}