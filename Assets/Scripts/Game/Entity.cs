using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] private Headspace _headspacePrefab;
    [SerializeField] private int _startingLevel = 1;
    [SerializeField] private Status _startingStatus = Status.Default;

    public ClassSO Class { get; private set; }
    public Status Status { get; private set; }
    public Stats Stats { get; private set; }
    public List<Ability> Abilities { get; private set; } = new();
    public Headspace Headspace { get; private set; }
    public int Level { get; private set; } = 1;

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
    }

    public Stat GetStat(StatName statName)
    {
        return Stats.Get(statName);
    }

    public void SetStat(StatName statName, int value)
    {
        Stats.Get(statName).SetValue(value);
    }
}
