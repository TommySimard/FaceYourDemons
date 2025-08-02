using System.Collections.Generic;

public interface IParty
{
    public List<Entity> Entities { get; }

    public void CheckStatus();
    public void ReactivateEntities();
    public bool HasActiveEntity();
}