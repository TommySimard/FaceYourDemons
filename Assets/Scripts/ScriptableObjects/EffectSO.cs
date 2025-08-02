using System.Collections.Generic;
using UnityEngine;

public abstract class EffectSO : ScriptableObject
{
    public abstract void Use(List<Entity> sources, List<Entity> targets);
}