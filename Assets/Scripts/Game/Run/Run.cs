using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private HeroParty _heroPartyPrefab;

    public HeroParty HeroParty { get; private set; }
    public List<Combat> Combats { get; private set; } = new();
    public RunStatus Status { get; private set; } = RunStatus.InProgress;

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
    }

    public void CheckStatus()
    {
        Combats.Last().CheckStatus();

        if (Combats.Last().Status == CombatStatus.Lost)
        {
            Status = RunStatus.Lost;
        }
    }
}