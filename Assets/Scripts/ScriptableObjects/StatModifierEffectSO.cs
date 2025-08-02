using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[CreateAssetMenu(fileName = "ModifierEffect", menuName = "Effect/Modifier Effect")]
public class StatModifierEffectSO : EffectSO
{
    [field: SerializeField] public List<StatType> Stats { get; private set; }
    [field: SerializeField] public int Modifier { get; private set; }
    [field: SerializeField] public Operation Operation { get; private set; }
    [field: SerializeField] public bool ModifierFromSources { get; private set; }

    public override void Use(List<Entity> sources, List<Entity> targets)
    {
        foreach (Entity target in targets)
        {

        }
    }

    private int GetFromSources(List<Entity> sources)
    {
        int result = 0;

        if (Operation == Operation.Add)
        {
            foreach (Entity source in sources)
            {
                
            }
        }
        else if (Operation == Operation.Multiply)
        {

        }


        return result;
    }

    private void SetTargets(List<Entity> targets)
    {
        foreach (Entity source in targets)
        {
            
        }
    }
}