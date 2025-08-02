using System.Collections.Generic;

public struct Turn
{
    public List<Play> Plays { get; private set; }
    public int TurnProgress { get; private set; }
    public CombatStatus Status { get; private set; }
    public EntityType PartyType { get; private set; }

    public Turn(EntityType partyType)
    {
        Plays = new();
        TurnProgress = Plays.Count;
        Status = CombatStatus.InProgress;
        PartyType = partyType;
    }

    public void AddPlay(Play lastPlay)
    {
        Plays.Add(lastPlay);

        TurnProgress = Plays.Count;
    }
}
