using System.Collections.Generic;

public struct Turn
{
    public Stack<Play> Plays { get; private set; }
    public TurnStatus Status { get; private set; }
    public IParty Party { get; private set; }

    public Turn(IParty party)
    {
        Party = party;
        Plays = new();
        Status = TurnStatus.InProgress;
    }

    public void CreatePlay(Skill skillUsed)
    {
        Play newPlay = new Play(skillUsed);

        Plays.Push(newPlay);
    }

    public void CheckStatus()
    {
        if (!Party.HasActiveEntity())
        {
            Status = TurnStatus.Done;

            Party.ReactivateEntities();
        }
    }
}
