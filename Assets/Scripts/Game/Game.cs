using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Run _runPrefab;
    [SerializeField] private List<ClassSO> _defaultClasses;
    [SerializeField] private CombatManager _combatManagerPrefab;
    [SerializeField] private EntityUpgrader _entityUpgraderPrefab;

    public CombatManager CombatManager { get; private set; }
    public EntityUpgrader EntityUpgrader { get; private set; }
    public List<ClassSO> SelectedClasses { get; private set; }
    public Run Run { get; private set; }

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
        SelectedClasses ??= _defaultClasses;

        CombatManager = Instantiate(_combatManagerPrefab, transform.position, Quaternion.identity);
        EntityUpgrader = Instantiate(_entityUpgraderPrefab, transform.position, Quaternion.identity);
        Run = Instantiate(_runPrefab, transform.position, Quaternion.identity);

        CombatManager.Init();
        EntityUpgrader.Init();
        Run.Init(SelectedClasses);
    }
}
