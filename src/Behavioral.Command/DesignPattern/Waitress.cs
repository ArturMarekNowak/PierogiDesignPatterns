namespace Behavioral.Command.DesignPattern;

public sealed class Waitress 
{
    public void Serve(ICommand command)
    {
        Console.WriteLine("Thank you for you order sir. I will see what i can do :D");
        command.Execute();
    }
}