using UnityEngine;

[CreateAssetMenu(fileName ="Skill Variable", menuName ="Variables/Skill Variable")]
public class SkillVariable : ScriptableObject
{
    [SerializeField] private SkillEvent _event;
    [SerializeField] private Skill _value;

    public Skill Value 
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
