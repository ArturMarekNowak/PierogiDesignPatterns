namespace Behavioral.Observer.DesignPattern;

public interface IPierogiObserver
{
    public string Name { get; init; }

    public void Update(IPierogiWarehouse pierogiWarehouse);
}