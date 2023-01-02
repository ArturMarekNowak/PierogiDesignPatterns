namespace Structural.Decorator.DesignPattern;

/// <summary>
/// Component
/// </summary>
public interface IDieteticService
{
    public int GetCalories();
    public IEnumerable<string> GetIngredients();
}