using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private HeroParty _heroPartyPrefab;
    [SerializeField] private Combat _combatPrefab;

    public PartyPitter PartyPitter { get; private set; }
    public EntityUpgrader EntityUpgrader { get; private set; }
    public HeroParty HeroParty { get; private set; }

    public static Game Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        HeroParty = Instantiate(_heroPartyPrefab, transform.position, Quaternion.identity);

        HeroParty.Init();
    }
}
