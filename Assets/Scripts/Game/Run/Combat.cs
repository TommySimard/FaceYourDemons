using System.Collections.Generic;

public class Combat
{
    public HeroParty Heroes { get; }
    public EnemyParty Monsters { get; private set; }
    public CombatStatus Status { get; private set; } = CombatStatus.Pending;
    public Round CurrentRound { get; private set; }
    public int RoundCount { get; private set; }

    public Combat(HeroParty heroes, EnemyParty monsters)
    {
        Heroes = heroes;
        Monsters = monsters;

        NextRound();
    }

    private void NextRound()
    {
        if (Status != CombatStatus.Pending) return;

        IParty actingParty = (RoundCount % 2 == 0) ? Heroes : Monsters;

        CurrentRound = new Round(actingParty);
        RoundCount++;
    }

    public void ExecuteCurrentTurn(Turn turn)
    {
        if (turn == null) return;

        turn.Execute();

        CheckStatus();

        if (Status == CombatStatus.Pending)
        {
            if (Round.Status == RoundStatus.Done)
            {
                NextRound();
            }
        }
        else
        {

        }
    }

    public void CheckStatus()
    {
        Heroes.CheckStatus();

        if (Heroes.Status == PartyStatus.Defeated)
        {
            Status = CombatStatus.Lost;

            return;
        }

        Monsters.CheckStatus();

        if (Monsters.Status == PartyStatus.Defeated)
        {
            Status = CombatStatus.Won;

            return;
        }
    }
}
