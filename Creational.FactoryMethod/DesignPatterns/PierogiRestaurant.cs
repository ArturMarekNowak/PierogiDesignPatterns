using Creational.FactoryMethod.Interface;
using Creational.FactoryMethod.Model;

namespace Creational.FactoryMethod.DesignPatterns;

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