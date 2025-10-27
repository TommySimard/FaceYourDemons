public class Round
{
    public IParty ActingParty { get; }
    public RoundStatus Status { get; private set; } = RoundStatus.Pending;
    public int TurnCount => ActingParty.ActiveEntityCount;

    public Round(IParty party)
    {
        ActingParty = party;
    }

    public void NextTurn()
    {
        Status = RoundStatus.Done;
    }
}