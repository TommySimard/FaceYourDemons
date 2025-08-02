using System.Collections.Generic;

public readonly struct Stats
{
    private static readonly StatName[] _statNames = { StatName.HP, StatName.MP, StatName.MGC, StatName.ATK, StatName.SHI, StatName.SPE, StatName.ATK, StatName.DEX, StatName.STRESS };

    private readonly Dictionary<StatName, Stat> _stats => new();

    public Stats(StatsSO statsSO)
    {
        InitializeStats(statsSO.Stats);
    }

    private void InitializeStats(Dictionary<StatName, Stat> stats)
    {
        foreach (StatName statName in _statNames)
        {
            _stats[statName] = new Stat(stats[statName]);
        }
    }

    public Stat Get(StatName statName)
    {
        return _stats[statName];
    }
}