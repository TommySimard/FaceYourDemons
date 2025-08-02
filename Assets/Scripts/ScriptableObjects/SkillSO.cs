using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Skill")]
public class SkillSO : ScriptableObject
{
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public int Value { get; private set; }
    [field: SerializeField] public EffectSO EffectSO { get; private set; }
    [field: SerializeField] public ModifierSO ModifierSO { get; private set; }

    public void Use(List<Entity> sources, List<Entity> targets)
    {
        int modifier = ModifierSO == null ? Value : ModifierSO.Calculate(Value, sources);

        EffectSO.Use(modifier, targets);
    }
}