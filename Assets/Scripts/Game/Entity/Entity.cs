using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] protected Headspace _headspacePrefab;
    [SerializeField] protected int _startingLevel = 1;
    [SerializeField] protected Status _startingStatus = Status.Default;

    public EntityType Type { get; protected set; }
    public ClassSO Class { get; protected set; }
    public Status Status { get; protected set; }
    public Stats Stats { get; protected set; }
    public List<Ability> Abilities { get; protected set; } = new();
    public Headspace Headspace { get; protected set; }
    public int Level { get; protected set; } = 1;

    private void Start()
    {
        // TODO
    }

    public void Init(ClassSO classSO)
    {
        Class = classSO;
        Stats = new Stats(classSO.StatsSO);
        Headspace = Instantiate(_headspacePrefab, transform.position, Quaternion.identity);
        Level = _startingLevel;
        
        SpecificInit();
    }

    protected abstract void SpecificInit();

    public Stat GetStat(StatName statName)
    {
        return Stats.Get(statName);
    }

    public void SetStat(StatName statName, int value)
    {
        Stats.Get(statName).SetValue(value);
    }
}
