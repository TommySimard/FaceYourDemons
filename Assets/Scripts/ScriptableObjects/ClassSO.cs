using UnityEngine;

public abstract class ClassSO : ScriptableObject
{
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public AbilitySO AbilitySO { get; private set; }
    [field: SerializeField] public StatsSO StatsSO { get; private set; }
    [field: SerializeField] public Sprite Sprite { get; private set; }
}