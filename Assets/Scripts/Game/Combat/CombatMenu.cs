using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMenu : MonoBehaviour
{
    [SerializeField] private GameObject _entityInformationPrefab;
    [SerializeField] private GameObject _entitySkillListPrefab;

    public GameObject EntityInformation { get; private set; }
    public GameObject EntitySkillList { get; private set; }

    public Entity SelectedEntity { get; private set; }

    void Start()
    {
        EntityInformation = Instantiate(_entityInformationPrefab, transform.position, Quaternion.identity);
        EntitySkillList = Instantiate(_entitySkillListPrefab, transform.position, Quaternion.identity);
    }

    private void ChangeSelectedEntity(Entity entity)
    {
        if (entity.Type == EntityType.Hero)
        {
            SelectedEntity = entity;
        }
        else
        {

        }
    }

    private void SelectAbility()
    {
        // TODO
    }
}
