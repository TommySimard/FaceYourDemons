using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public List<Turn> Turns { get; private set; }
    public HeroParty HeroParty { get; private set; }
    public EnemyParty EnemyParty { get; private set; }

    private void Start()
    {
        // TODO
    }

    public void Init()
    {

    }

    private void InitializeEnemyParty()
    {
        // TODO
    }
}
