using System.Collections.Generic;
using UnityEngine;

public abstract class ModifierSO : ScriptableObject
{
    [field: SerializeField] public int Value { get; private set; }

    public abstract int Calculate(int value, List<Entity> sources);
}