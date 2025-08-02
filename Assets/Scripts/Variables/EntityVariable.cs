using UnityEngine;

[CreateAssetMenu(fileName ="Entity Variable", menuName ="Variables/Entity Variable")]
public class EntityVariable : ScriptableObject
{
    [SerializeField] private EntityEvent _event;
    [SerializeField] private Entity _value;

    public Entity Value 
    { 
        get { return _value; } 
        set 
        { 
            if (_value != value)
            {
                _value = value;

                if (_event != null) 
                {
                    _event?.Raise(value); 
                }
            }
        } 
    }
}
