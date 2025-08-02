using UnityEngine;

[CreateAssetMenu(fileName ="Float Variable", menuName ="Variables/Float Variable")]
public class FloatVariable : ScriptableObject
{
    [SerializeField] private FloatEvent _event;
    [SerializeField] private float _value;

    public float Value 
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
