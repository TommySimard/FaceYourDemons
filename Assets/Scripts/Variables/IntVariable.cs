using UnityEngine;

[CreateAssetMenu(fileName ="Int Variable", menuName ="Variables/Int Variable")]
public class IntVariable : ScriptableObject
{
    [SerializeField] private IntEvent _event;
    [SerializeField] private int _value;
    
    public int Value 
    { 
        get { return _value; } 
        set 
        { 
            if (_value != value)
            {
                _value = value;

                if (_event != null) 
                {
                    _event.Raise(value); 
                }
            }
        } 
    }
}
