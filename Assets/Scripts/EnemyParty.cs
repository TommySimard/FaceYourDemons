using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab = new();
    [SerializeField] private List<ClassSO> _classSOs = new();
    [SerializeField] private int _partySize = 4;

    public List<Entity> Enemies { get; private set; } = new();

    private void Start()
    {
        // TODO
    }

    public void Init()
    {
        InitializeEnemies();
    }

    private void InitializeEnemies()
    {
        Enemy enemy;

        foreach (ClassSO classSO in _classSOs)
        {
            enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);

            enemy.Init(classSO);
            Enemies.Add(enemy);
        }
    }
}
