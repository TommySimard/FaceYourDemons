using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] protected Headspace _headspacePrefab;
    [SerializeField] protected int _startingLevel = 1;
    [SerializeField] protected SkillEvent _skillUsedEvent;

    public EntityType Type { get; protected set; }
    public Class Class { get; protected set; }
    public EntityStatus Status { get; protected set; }
    public Stats Stats { get; protected set; }
    public List<Skill> Skills { get; protected set; } = new();
    public Headspace Headspace { get; protected set; }
    public int Level { get; protected set; } = 1;
    public bool IsActive { get; protected set; } = true;

    private void Start()
    {
        // TODO
    }

    public void Init(ClassSO classSO)
    {
        Type = classSO.Type;
        Class = new Class(classSO);
        Stats = new Stats(classSO.StatsSO);
        Headspace = Instantiate(_headspacePrefab, transform.position, Quaternion.identity);
        Level = _startingLevel;

        Skills.Add(new Skill(classSO.SkillSO));
    }

    public Stat GetStat(StatName statName)
    {
        return Stats.Get(statName);
    }

    public void SetStat(StatName statName, int value)
    {
        Stats.Get(statName).SetValue(value);
    }

    public void Act(Skill skillToUse)
    {
        skillToUse.Use(skillToUse.Sources, skillToUse.Targets);

        IsActive = false;

        _skillUsedEvent.Raise(skillToUse);
    }

    public void Activate()
    {
        if (Status != EntityStatus.Dead)
        {
            IsActive = true;
        }
    }
}
