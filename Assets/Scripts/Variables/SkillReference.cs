using System;

[Serializable]
public class SkillReference
{
    public bool useConstant;
    public Skill constantValue;
    public SkillVariable variable;

    public Skill Value { get { return useConstant ? constantValue : variable.Value; } }
}
