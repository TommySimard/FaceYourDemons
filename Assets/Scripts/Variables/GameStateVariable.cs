using UnityEngine;

[CreateAssetMenu(fileName ="Game State Variable", menuName ="Variables/Game State Variable")]
public class GameStateVariable : ScriptableObject
{
    [SerializeField] private GameStateEvent _event;
    [SerializeField] private GameState _value;
    
    public GameState Value 
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
