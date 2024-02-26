namespace Behavioral.Observer.DesignPattern;

public interface IPierogiWarehouse
{
    public int NumberOfPierogi { get; set; }
    
    public void Attach(IPierogiObserver pierogiObserver);
    public void Detach(IPierogiObserver pierogiObserver);
    public void Notify();
}