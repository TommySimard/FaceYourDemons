using System.Collections.Generic;
using UnityEngine;

public struct Combat
{
    private HeroParty _heroParty;

    public EnemyParty EnemyParty { get; private set; }
    public List<Turn> Turns { get; private set; }
    public CombatStatus Status { get; private set; }

    public Combat(HeroParty heroParty, EnemyParty enemyParty)
    {
        _heroParty = heroParty;
        EnemyParty = enemyParty;
        Turns = new();
        Status = CombatStatus.InProgress;
    }

    public void CheckStatus()
    {
        _heroParty.CheckStatus();

        if (_heroParty.Status == PartyStatus.Defeated)
        {
            Status = CombatStatus.Lost;
        }

        EnemyParty.CheckStatus();

        if (EnemyParty.Status == PartyStatus.Defeated)
        {
            Status = CombatStatus.Won;
        }
    }
}
