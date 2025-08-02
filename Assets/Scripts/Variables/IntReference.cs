using System;
using UnityEngine;

[Serializable]
public class IntReference
{
    [SerializeField] private bool useConstant;
    [SerializeField] private int constantValue;
    [SerializeField] private IntVariable variable;

    public float Value
    {
        get { return useConstant ? constantValue : variable.Value; }
    }
}
