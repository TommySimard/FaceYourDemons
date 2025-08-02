using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Stats")]
public class StatsSO : ScriptableObject
{
    private static readonly StatName[] _statNames = { StatName.HP, StatName.MP, StatName.MGC, StatName.ATK, StatName.SHI, StatName.SPE, StatName.ATK, StatName.DEX, StatName.STRESS };

    [SerializeField] private int[] _maxes = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    [SerializeField] private int[] _mins = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    [SerializeField] private int[] _values = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public Dictionary<StatName, Stat> Stats => InitializeStats();

    private Dictionary<StatName, Stat> InitializeStats()
    {
        Dictionary<StatName, Stat> stats = new();

        for (int i = 0; i < _statNames.Length; i++)
        {
            stats[_statNames[i]] = new Stat(_statNames[i], _mins[i], _maxes[i], _values[i]);
        }

        return stats;
    }
}