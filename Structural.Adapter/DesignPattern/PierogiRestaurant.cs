using Structural.Adapter.Interfaces;
using Structural.Adapter.Model;

namespace Structural.Adapter.DesignPattern;

public class PierogiWithFruitsRestaurant : IPierogiRestaurant
{
    private Pierogi _pierogi { get; set; }

    public PierogiWithFruitsRestaurant(Pierogi pierogi)
    {
        _pierogi = pierogi;
        _pierogi.Type = PierogiType.WithBlueberries;
    }

    public Pierogi ServePierogi()
    {
        return _pierogi;
    }
}