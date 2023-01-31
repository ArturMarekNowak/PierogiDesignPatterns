using Behavioral.Memento.Model;

namespace Behavioral.Memento.DesignPattern;

public class PierogiOriginator
{
    public Pierogi pierogiState { get; set; }

    public PierogiMemento CreateMemento()
    {
        return new PierogiMemento(pierogiState);
    }

    public void SetMemento(PierogiMemento pierogiMemento)
    {
        pierogiState = pierogiMemento.GetState();
    }
}