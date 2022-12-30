using Creational.AbstractFactory.Model;

namespace Creational.AbstractFactory.DesignPattern;

public abstract class PierogiAbstractFactory
{
    public abstract PierogiWithMeat CookPierogiWithMeat();
    public abstract PierogiWithCabbage CookPierogiWithCabbage();
}

public class PierogiExpensiveRestaurant : PierogiAbstractFactory
{
    public override PierogiWithMeat CookPierogiWithMeat()
    {
        return new PierogiWithMeat(30, MeatType.Pork);
    }

    public override PierogiWithCabbage CookPierogiWithCabbage()
    {
        return new PierogiWithCabbage(30, true);
    }
}


public class PierogiCheapRestaurant : PierogiAbstractFactory
{
    public override PierogiWithMeat CookPierogiWithMeat()
    {
        return new PierogiWithMeat(10, MeatType.Lamb);
    }

    public override PierogiWithCabbage CookPierogiWithCabbage()
    {
        return new PierogiWithCabbage(10, false);
    }
}