namespace Behavioral.Command.DesignPattern;

public interface IReceiver
{
    void Respond(ICommand command);
}
