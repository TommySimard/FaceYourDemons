using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour, IParty
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private int _maxPartySize = 4;
    [SerializeField] private int _entityOffset;

    public List<Entity> Entities { get; private set; } = new();
    public PartyStatus Status { get; private set; } = PartyStatus.Default;

    public void Init(List<ClassSO> generatedClasses)
    {
        InitializeEntities(generatedClasses);
    }

    private void InitializeEntities(List<ClassSO> generatedClasses)
    {
        Enemy enemy;

        foreach (ClassSO classSO in generatedClasses)
        {
            enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);

            enemy.Init(classSO);
            Entities.Add(enemy);
        }
    }

    public void CheckStatus()
    {
        foreach (Entity enemy in Entities)
        {
            if (enemy.Status != EntityStatus.Dead)
            {
                return;
            }
        }

        Status = PartyStatus.Defeated;
    }
    
    public void ReactivateEntities()
    {
        foreach (Entity entity in Entities)
        {
            entity.Activate();
        }
    }

    public bool HasActiveEntity()
    {
        foreach (Entity entity in Entities)
        {
            if (entity.IsActive)
            {
                return true;
            }
        }
        
        return false;
    }
}
