namespace Behavioral.Command.DesignPattern;

public sealed class Owner : IReceiver
{
    public void Respond(ICommand command)
    {
        switch (command)
        {
            case BuyPierogi: 
                Console.WriteLine($"You should probably go to cook with such request :/");
                break;
                
            case Compliment:
                Console.WriteLine("We are just doing our job sir :D");
                break;
        }
    }
}