using Structural.Decorator.Interfaces;
using Structural.Decorator.Model;

namespace Structural.Decorator.DesignPattern;

/// <summary>
/// Concrete component
/// </summary>
public class PlainPierogi : IDieteticService, IPierogi
{
    public Guid Guid { get; }
    public int Count { get; set; }
    public PierogiType Type { get; set; }
    
    public PlainPierogi(int count)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiType.WithPotatoesAndCheese;
    }
    
    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}";
    }
    
    public int GetCalories()
    {
        return 300;
    }

    public IEnumerable<string> GetIngredients()
    {
        return new[] { "pierogi batter", "mashed potatoes and cheese" };
    }
}

/// <summary>
/// Decorator
/// </summary>
public abstract class PierogiGravy : IDieteticService
{
    public abstract int GetCalories();
    public abstract IEnumerable<string> GetIngredients();
}

/// <summary>
/// Concrete decorator
/// </summary>
public class PierogiWithButter : IDieteticService
{
    private PlainPierogi _plainPierogi { get; init; }

    public PierogiWithButter(PlainPierogi plainPierogi)
    {
        _plainPierogi = plainPierogi;
    }
    
    public int GetCalories()
    {
        return _plainPierogi.GetCalories() + 100;
    }

    public IEnumerable<string> GetIngredients()
    {
        return _plainPierogi.GetIngredients().Append("liquid butter");
    }
}

/// <summary>
/// Concrete decorator
/// </summary>
public class PierogiWithPorkScratching : IDieteticService
{
    private PlainPierogi _plainPierogi { get; init; }

    public PierogiWithPorkScratching(PlainPierogi plainPierogi)
    {
        _plainPierogi = plainPierogi;
    }
    
    public int GetCalories()
    {
        return _plainPierogi.GetCalories() + 150;
    }

    public IEnumerable<string> GetIngredients()
    {
        return _plainPierogi.GetIngredients().Append("pork scratching");
    }
}
