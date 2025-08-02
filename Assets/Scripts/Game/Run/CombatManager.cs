using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private Run _run;

    [SerializeField] private CombatMenu _skillMenuPrefab;
    [SerializeField] private EnemyParty _enemyPartyPrefab;

    public CombatMenu CombatMenu { get; private set; }

    public static CombatManager Instance { get; private set; }

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
        _run = Run.Instance;   
    }

    public void Init()
    {
        CombatMenu = Instantiate(_skillMenuPrefab, transform.position, Quaternion.identity);
    }

    public void GenerateEnemyParty()
    {
        EnemyParty enemyParty = Instantiate(_enemyPartyPrefab, transform.position, Quaternion.identity);

        // enemyParty.Init();
    }
}