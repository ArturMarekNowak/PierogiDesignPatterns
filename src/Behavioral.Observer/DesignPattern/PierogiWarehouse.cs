namespace Behavioral.Observer.DesignPattern;

public class PierogiWarehouse : IPierogiWarehouse
{
    public int NumberOfPierogi { get; set; }
    private List<IPierogiObserver> _pierogiObservers = new();

    public void Attach(IPierogiObserver pierogiObserver)
    {
        _pierogiObservers.Add(pierogiObserver);
    }

    public void Detach(IPierogiObserver pierogiObserver)
    {
        _pierogiObservers.Remove(pierogiObserver);
    }

    public void Notify()
    {
        foreach (var pierogiObserver in _pierogiObservers)
        {
            pierogiObserver.Update(this);
        }
    }

    public void SetPierogiCount(int pierogiCount)
    {
        NumberOfPierogi = pierogiCount;
        Notify();
    }
}