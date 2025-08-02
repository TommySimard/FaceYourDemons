using UnityEngine;

public abstract class ClassSO : ScriptableObject
{
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public EntityType Type { get; private set; }
    [field: SerializeField] public SkillSO SkillSO { get; private set; }
    [field: SerializeField] public StatsSO StatsSO { get; private set; }
    [field: SerializeField] public Sprite Sprite { get; private set; }
}