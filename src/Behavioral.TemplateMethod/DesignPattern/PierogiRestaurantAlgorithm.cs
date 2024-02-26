using Behavioral.TemplateMethod.Model;

namespace Behavioral.TemplateMethod.DesignPattern;

public abstract class PierogiRestaurantAlgorithm
{
    protected Pierogi _pierogi;
    
    protected abstract void BuyIngredients();
    protected abstract void PrepareDishes();
    protected abstract Pierogi CookPierogi();

    public Pierogi ServePierogi()
    {
        BuyIngredients();
        PrepareDishes();
        return CookPierogi();
    }
}