using Structural.Bridge.Interfaces;

namespace Structural.Bridge.DesignPattern;

public abstract class PierogiRestaurant
{
    protected IPierogi _pierogi;

    protected PierogiRestaurant(IPierogi pierogi)
    {
        _pierogi = pierogi;
    }
    
    public abstract IPierogi ServePierogi();
}

public class SmallPierogiRestaurant : PierogiRestaurant
{
    public SmallPierogiRestaurant(IPierogi pierogi) : base(pierogi)
    {
        _pierogi = pierogi;
        _pierogi.Count = 10;
    }
    
    public override IPierogi ServePierogi()
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
    
    public override IPierogi ServePierogi()
    {
        return _pierogi;
    }
}