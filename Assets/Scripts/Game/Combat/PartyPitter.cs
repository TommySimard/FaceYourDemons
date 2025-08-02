using System.Collections.Generic;
using UnityEngine;

public class PartyPitter : MonoBehaviour
{
    private HeroParty _heroparty;

    [SerializeField] private CombatMenu _skillMenuPrefab;
    [SerializeField] private EnemyParty _enemyPartyPrefab;

    public CombatMenu CombatMenu { get; private set; }
    public List<Combat> Combats { get; private set; } = new();
    public Turn CurrentTurn { get; private set; } = new();
    public List<Play> Plays { get; private set; } = new();
    public Entity SelectedEntity { get; private set; }

    public static PartyPitter Instance { get; private set; }

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
        _heroparty = Game.Instance.HeroParty;
        CombatMenu = Instantiate(_skillMenuPrefab, transform.position, Quaternion.identity);
    }

    private EnemyParty GenerateEnemyParty()
    {
        return Instantiate(_enemyPartyPrefab, transform.position, Quaternion.identity);
    }

    private void CreateCombat()
    {

    }
}