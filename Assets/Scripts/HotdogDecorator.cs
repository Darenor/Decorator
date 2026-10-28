public abstract class HotdogDecorator : Hotdog
{
    protected readonly Hotdog decoratedHotdog;

    protected HotdogDecorator(Hotdog hotdog)
        : base(hotdog.GetName())
    {
        decoratedHotdog = hotdog;
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost();
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight();
    }
}

public class PicklesDecorator : HotdogDecorator
{
    private readonly IngredientData ingredient;

    public PicklesDecorator(
        Hotdog hotdog,
        IngredientData ingredient
    ) : base(hotdog)
    {
        this.ingredient = ingredient;
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName()
            + " с маринованными огурцами";
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + ingredient.Cost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + ingredient.Weight;
    }
}

public class SweetOnionDecorator : HotdogDecorator
{
    private readonly IngredientData ingredient;

    public SweetOnionDecorator(
        Hotdog hotdog,
        IngredientData ingredient
    ) : base(hotdog)
    {
        this.ingredient = ingredient;
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName()
            + " со сладким луком";
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + ingredient.Cost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + ingredient.Weight;
    }
}
