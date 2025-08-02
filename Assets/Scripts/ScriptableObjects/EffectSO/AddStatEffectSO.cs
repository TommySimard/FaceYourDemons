using System.Collections.Generic;
using UnityEngine;

public class AddStatEffectSO : EffectSO
{
    [field: SerializeField] public StatName Stat { get; private set; }

    public override void Use(int modifier, List<Entity> targets)
    {
        int newValue;

        foreach (Entity target in targets)
        {
            newValue = target.GetStat(Stat).Value + modifier;

            target.GetStat(Stat).SetValue(newValue);
        }
    }
}