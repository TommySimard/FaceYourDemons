using UnityEngine;

public abstract class AbilitySO : ScriptableObject
{
    [field: SerializeField] public string Description { get; private set; }
}