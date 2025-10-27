using System.Collections.Generic;

public interface IParty
{
    public List<Entity> Entities { get; }
    public List<Entity> ActiveEntities { get; }
    public EntityType Type { get; }
    public int ActiveEntityCount { get; }

    public void Init(List<ClassSO> classSOs);
    public void CheckStatus();
    public void ReactivateEntities();
}