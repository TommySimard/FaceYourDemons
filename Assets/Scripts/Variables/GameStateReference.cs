using System;

[Serializable]
public class GameStateReference
{
    public bool useConstant;
    public GameState constantValue;
    public GameStateVariable variable;

    public GameState Value
    {
        get { return useConstant ? constantValue : variable.Value; }
    }
}
