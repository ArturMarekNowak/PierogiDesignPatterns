using Creational.Builder.Model;

namespace Creational.Builder.DesignPattern;

public class PierogiWithMeatCook : IPierogiBuilder
{
    private Pierogi pierogiInstance;
    
    public PierogiWithMeatCook()
    {
        pierogiInstance = new Pierogi();
    }

    public void SetPierogiCount()
    {
        pierogiInstance.Count = 10;
    }

    public void SetPierogiType()
    {
        pierogiInstance.Type = PierogiType.WithMeat;
    }
    
    public Pierogi Cook()
    {
        return pierogiInstance;
    }
}

public class PierogiWithFruitsCook : IPierogiBuilder
{
    private Pierogi pierogiInstance;
    
    public PierogiWithFruitsCook()
    {
        pierogiInstance = new Pierogi();
    }

    public void SetPierogiCount()
    {
        pierogiInstance.Count = 10;
    }

    public void SetPierogiType()
    {
        pierogiInstance.Type = PierogiType.WithStrawberries;
    }
    
    public Pierogi Cook()
    {
        return pierogiInstance;
    }
}

public class PierogiWithoutMeatCook : IPierogiBuilder
{
    private Pierogi pierogiInstance;
    
    public PierogiWithoutMeatCook()
    {
        pierogiInstance = new Pierogi();
    }

    public void SetPierogiCount()
    {
        pierogiInstance.Count = 10;
    }

    public void SetPierogiType()
    {
        pierogiInstance.Type = PierogiType.WithCabbage;
    }
    
    public Pierogi Cook()
    {
        return pierogiInstance;
    }
}