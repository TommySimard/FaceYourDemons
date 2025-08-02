using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Turn
{
    public List<Play> Plays { get; private set; } = new();
    public CombatStatus Status { get; private set; } = CombatStatus.InProgress;

    public Turn()
    {

    }
}
