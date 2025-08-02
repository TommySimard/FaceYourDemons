using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveAbility", menuName = "Ability/Active Ability")]
public abstract class AbilitySO : ScriptableObject
{
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public AreaOfEffect Sources { get; private set; }
    [field: SerializeField] public AreaOfEffect Targets { get; private set; }
    [field: SerializeField] public EffectSO EffectSO { get; private set; }

    public abstract void Use(List<Entity> sources, List<Entity> targets);
}