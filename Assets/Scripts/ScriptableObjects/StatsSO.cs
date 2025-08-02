using System.Collections.Generic;
using UnityEngine;

public abstract class StatsSO : ScriptableObject
{
    [field: SerializeField] public List<int> Mins { get; private set; }
    [field: SerializeField] public List<int> Maxes { get; private set; }
    [field: SerializeField] public List<int> Values { get; private set; }
}