using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HeroParty : MonoBehaviour, IParty
{
    [SerializeField] private Hero _heroPrefab;
    [SerializeField] private int _maxPartySize = 4;
    [SerializeField] private int _entityOffset;

    public List<Entity> Entities { get; private set; } = new();
    public List<Entity> ActiveEntities => Entities.Where(e => e.IsActive).ToList();
    public PartyStatus Status { get; private set; } = PartyStatus.Default;
    public EntityType Type { get; } = EntityType.Hero;
    public int ActiveEntityCount => Entities.Count(e=> e.IsActive);

    public void Init(List<ClassSO> classSOs)
    {
        InitializeEntities(classSOs);
    }

    private void InitializeEntities(List<ClassSO> classSOs)
    {
        Hero hero;

        foreach (ClassSO classSO in classSOs)
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
}