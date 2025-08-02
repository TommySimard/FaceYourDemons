using System;

[Serializable]
public class EntityReference
{
    public bool useConstant;
    public Entity constantValue;
    public EntityVariable variable;

    public Entity Value { get { return useConstant ? constantValue : variable.Value; } }
}
