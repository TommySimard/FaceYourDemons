using System.Collections.Generic;

public class MultModifierSO : ModifierSO
{
    public override int Calculate(int value, List<Entity> sources)
    {
        return value * Value;
    }
}