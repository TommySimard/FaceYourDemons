using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMenu : MonoBehaviour
{
    [SerializeField] private GameObject _entityInformationPrefab;
    [SerializeField] private GameObject _entitySkillListPrefab;
    [SerializeField] private GameObject _skillUseInformationPrefab;

    public GameObject EntityInformation { get; private set; }
    public GameObject EntitySkillList { get; private set; }
    public GameObject SkillUseInformation { get; private set; }

    void Start()
    {
        EntityInformation = Instantiate(_entityInformationPrefab, transform.position, Quaternion.identity);
        EntitySkillList = Instantiate(_entitySkillListPrefab, transform.position, Quaternion.identity);
        SkillUseInformation = Instantiate(_skillUseInformationPrefab, transform.position, Quaternion.identity);
    }
}
