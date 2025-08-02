using System;
using System.Collections.Generic;

public class Ability
{
    private readonly Action<List<Entity>, List<Entity>> _use;

    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<Trigger> Triggers { get; private set; }

    public Ability(AbilitySO abilitySO)
    {
        _use = abilitySO.Use;

        Name = abilitySO.name;
        Description = abilitySO.Description;
    }

    public void Use(List<Entity> sources, List<Entity> targets)
    {
        _use?.Invoke(sources, targets);
    }  
}