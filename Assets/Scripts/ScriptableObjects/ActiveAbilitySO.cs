using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveAbility", menuName = "Ability/Active Ability")]
public class ActiveAbilitySO : AbilitySO
{
    public override void Use(List<Entity> sources, List<Entity> targets)
    {
        EffectSO.Use(sources, targets);
    }
}