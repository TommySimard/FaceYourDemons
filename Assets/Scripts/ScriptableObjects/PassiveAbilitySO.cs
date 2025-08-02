using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PassiveAbility", menuName = "Ability/Passive Ability")]
public class PassiveAbilitySO : AbilitySO
{
    [field: SerializeField] public List<Trigger> Triggers { get; private set; }

    public override void Use(List<Entity> sources, List<Entity> targets)
    {
        EffectSO.Use(sources, targets);
    }
}