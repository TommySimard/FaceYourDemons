using System.Collections.Generic;
using UnityEngine;

public class HeroParty : MonoBehaviour, IParty
{
    [SerializeField] private Hero _heroPrefab;
    [SerializeField] private int _maxPartySize = 4;
    [SerializeField] private int _entityOffset;

    public List<Entity> Entities { get; private set; } = new();
    public PartyStatus Status { get; private set; } = PartyStatus.Default;

    public void Init(List<ClassSO> selectedClassSOs)
    {
        InitializeEntities(selectedClassSOs);
    }

    private void InitializeEntities(List<ClassSO> selectedClassSOs)
    {
        Hero hero;

        foreach (ClassSO classSO in selectedClassSOs)
        {
            hero = Instantiate(_heroPrefab, transform.position, Quaternion.identity);

            hero.Init(classSO);
            Entities.Add(hero);
        }
    }

    public void CheckStatus()
    {
        foreach (Entity hero in Entities)
            {
                if (hero.Status != EntityStatus.Dead)
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