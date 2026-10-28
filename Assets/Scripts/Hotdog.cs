public abstract class Hotdog
{
    private readonly string name;

    protected Hotdog(string name)
    {
        this.name = name;
    }

    public virtual string GetName()
    {
        return name;
    }

    public abstract int GetCost();

    public abstract int GetWeight();
}

public class ClassicHotdog : Hotdog
{
    private readonly HotdogData data;

    public ClassicHotdog(HotdogData data) : base(data.HotdogName)
    {
        this.data = data;
    }

    public override int GetCost()
    {
        return data.Cost;
    }

    public override int GetWeight()
    {
        return data.Weight;
    }
}

public class CheeseHotdog : Hotdog
{
    private readonly HotdogData data;

    public CheeseHotdog(HotdogData data) : base(data.HotdogName)
    {
        this.data = data;
    }

    public override int GetCost()
    {
        return data.Cost;
    }

    public override int GetWeight()
    {
        return data.Weight;
    }
}

public class SpicyHotdog : Hotdog
{
    private readonly HotdogData data;

    public SpicyHotdog(HotdogData data) : base(data.HotdogName)
    {
        this.data = data;
    }

    public override int GetCost()
    {
        return data.Cost;
    }

    public override int GetWeight()
    {
        return data.Weight;
    }
}
