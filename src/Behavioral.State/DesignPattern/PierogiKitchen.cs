namespace Behavioral.State.DesignPattern;

public class PierogiKitchen
{
    public IPierogiState State { get; protected internal set; }

    public PierogiKitchen(IPierogiState state)
    {
        State = state;
    }
    
    public void Request()
    {
        State.Handle(this);
    }
}