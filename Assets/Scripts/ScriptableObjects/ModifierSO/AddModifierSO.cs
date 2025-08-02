using System.Collections.Generic;

public class AddModifierSO : ModifierSO
{
    public override int Calculate(int value, List<Entity> sources)
    {
        return value + Value;
    }
}