namespace Behavioral.Mediator.DesignPattern;

public interface IPierogiMediator
{
    public void Send(string message, IPierogiGentleman gentleman);
}