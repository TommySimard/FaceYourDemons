using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyParty : MonoBehaviour, IParty
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<ClassSO> _enemyClassSOs;
    [SerializeField] private int _maxPartySize = 4;
    [SerializeField] private int _entityOffset;

    public List<Entity> Entities { get; private set; } = new();
    public List<Entity> ActiveEntities => Entities.Where(e => e.IsActive).ToList();
    public PartyStatus Status { get; private set; } = PartyStatus.Default;
    public EntityType Type { get; } = EntityType.Monster;
    public int ActiveEntityCount => Entities.Count(e=> e.IsActive);

    public void Init(List<ClassSO> classSOs)
    {
        InitializeEntities(GetRandomClassSOs());
    }

    public List<ClassSO> GetRandomClassSOs()
    {
        List<ClassSO> randomClassSOs = new();
        int partySize = Random.Range(0, _maxPartySize);
        ClassSO randomClassSO;
    
        for (int i = 0; i < partySize; i++)
        {
            randomClassSO = _enemyClassSOs[Random.Range(0, _enemyClassSOs.Count)];
            randomClassSOs.Add(randomClassSO);
        }

        return randomClassSOs;
    }

    private void InitializeEntities(List<ClassSO> randomClassSOs)
    {
        Enemy enemy;

        foreach (ClassSO classSO in randomClassSOs)
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
}
