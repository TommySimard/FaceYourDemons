using System.Collections.Generic;
using UnityEngine;

public struct Combat
{
    private readonly HeroParty _heroParty;

    public EnemyParty EnemyParty { get; private set; }
    public Stack<Turn> Turns { get; private set; }
    public CombatStatus Status { get; private set; }

    public Combat(HeroParty heroParty, EnemyParty enemyParty)
    {
        _heroParty = heroParty;
        EnemyParty = enemyParty;
        Turns = new();
        Status = CombatStatus.InProgress;

        Turns.Push(CreateTurn());
    }

    public Turn CreateTurn()
    {
        Turn newTurn;

        if ((Turns.Count + 1) % 2 == 0)
        {
            newTurn = new Turn(EnemyParty);
        }
        else
        {
            newTurn = new Turn(_heroParty);
        }

        return newTurn;
    }

    public void NextTurn()
    {
        Turns.Push(CreateTurn());
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

        Turns.Peek().CheckStatus();

        if (Turns.Peek().Status == TurnStatus.Done)
        {
            NextTurn();
        }
    }
}
