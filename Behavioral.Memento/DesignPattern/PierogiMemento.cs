using Behavioral.Memento.Model;

namespace Behavioral.Memento.DesignPattern;

public class PierogiMemento
{
    private readonly Pierogi _pierogiState;

    public PierogiMemento(Pierogi pierogiState)
    {
        _pierogiState = pierogiState;
    }

    public Pierogi GetState()
    {
        return _pierogiState;
    }
}