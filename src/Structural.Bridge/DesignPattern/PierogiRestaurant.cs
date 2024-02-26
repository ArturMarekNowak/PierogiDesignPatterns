using Structural.Bridge.Interfaces;

namespace Structural.Bridge.DesignPattern;

public class PierogiRestaurant
{
    protected IPierogi _pierogi;

    public PierogiRestaurant(IPierogi pierogi)
    {
        _pierogi = pierogi;
        _pierogi.Count = 10;
    }
    
    public IPierogi ServePierogi()
    {
        return _pierogi;
    }
}

public class BigPierogiRestaurant : PierogiRestaurant
{
    public BigPierogiRestaurant(IPierogi pierogi) : base(pierogi)
    {
        _pierogi = pierogi;
        _pierogi.Count = 100;
    }
}