using System.Collections.Generic;
using UnityEngine;

public abstract class EffectSO : ScriptableObject
{
    public abstract void Use(int modifier, List<Entity> targets);
}