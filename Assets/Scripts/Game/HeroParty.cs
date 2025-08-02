using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroParty : MonoBehaviour
{
    [SerializeField] private Hero _heroPrefab = new();
    [SerializeField] private List<ClassSO> _classSOs = new();
    [SerializeField] private int _partySize = 4;

    public List<Entity> Heroes { get; private set; } = new();

    private void Start()
    {
        // TODO
    }

    public void Init()
    {
        InitializeHeroes();
    }

    private void InitializeHeroes()
    {
        Hero hero;

        foreach (ClassSO classSO in _classSOs)
        {
            hero = Instantiate(_heroPrefab, transform.position, Quaternion.identity);

            hero.Init(classSO);
            Heroes.Add(hero);
        }
    }
}
