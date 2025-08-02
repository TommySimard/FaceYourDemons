using System;
using System.Collections.Generic;

public class Ability
{
    private readonly Action<List<Entity>, List<Entity>> _use;

    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<AbilityTrigger> Triggers { get; private set; }

    public Ability(AbilitySO abilitySO)
    {
        _use = abilitySO.Use;
        Name = abilitySO.name;
        Description = abilitySO.Description;
        Triggers = abilitySO.Triggers;
    }

    public void Use(List<Entity> sources, List<Entity> targets)
    {
        _use?.Invoke(sources, targets);
    }

    public override string ToString()
    {
        return $"Ability ({Name}) \n- Description: {Description}";
    }

    public string ToShortString()
    {
        return $"Ability ({Name})";
    }
}