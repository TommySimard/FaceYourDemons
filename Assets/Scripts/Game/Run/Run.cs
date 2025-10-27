using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private HeroParty _heroPartyPrefab;
    [SerializeField] private EnemyParty _enemyPartyPrefab;

    public HeroParty HeroParty { get; private set; }
    public Stack<Combat> Combats { get; private set; } = new();
    public List<Combat> WonCombats { get; private set; } = new();
    public RunStatus Status { get; private set; } = RunStatus.Pending;

    public static Run Instance { get; private set; }

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

    public void Init(List<ClassSO> selectedClasses)
    {
        HeroParty = Instantiate(_heroPartyPrefab, transform.position, Quaternion.identity);

        HeroParty.Init(selectedClasses);

        Combats.Push(CreateCombat());
    }

    public Combat CreateCombat()
    {
        EnemyParty enemyParty = Instantiate(_enemyPartyPrefab, transform.position, Quaternion.identity);

        enemyParty.Init();

        return new Combat(HeroParty, enemyParty);
    }

    public void NextCombat()
    {
        WonCombats.Add(Combats.Pop());

        if (Combats.Count < 1)
        {
            Combats.Push(CreateCombat());
        }
    }

    public void CheckStatus()
    {
        Combats.Peek().CheckStatus();

        if (Combats.Peek().Status == CombatStatus.Lost)
        {
            Status = RunStatus.Lost;
        }
        else if (Combats.Peek().Status == CombatStatus.Won)
        {
            NextCombat();
        }
    }

    public void CreatePlay(Skill skillUsed)
    {
        

        CheckStatus();
    }
}