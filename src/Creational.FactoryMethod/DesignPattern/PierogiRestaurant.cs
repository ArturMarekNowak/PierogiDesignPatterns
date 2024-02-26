using Creational.Factory.Interfaces;
using Creational.Factory.Model;

namespace Creational.Factory.DesignPattern;

public abstract class PierogiRestaurant
{
    public abstract IPierogi ServePierogi();
}

public class PierogiWithFruitsRestaurant : PierogiRestaurant
{
    public override IPierogi ServePierogi()
    {
        return new PierogiWithStrawberries(10);
    }
}

public class PierogiWithMeatRestaurant : PierogiRestaurant
{
    public override IPierogi ServePierogi()
    {
        return new PierogiWithMeat(10);
    }
}

public class PierogiWithoutMeatRestaurant : PierogiRestaurant
{
    public override IPierogi ServePierogi()
    {
        return new PierogiWithCabbage(10);
    }
}