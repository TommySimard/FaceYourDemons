using System;
using System.Collections.Generic;

public class Skill
{
    private readonly Action<List<Entity>, List<Entity>> _use;

    public Entity Owner { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public AreaOfEffect AreaOfEffect { get; private set; }
    public List<Entity> Sources { get; private set; } = new();
    public List<Entity> Targets { get; private set; } = new();

    public Skill(SkillSO skillSO)
    {
        _use = skillSO.Use;
        Name = skillSO.name;
        Description = skillSO.Description;
        AreaOfEffect = skillSO.AreaOfEffect;
    }

    public void Use(List<Entity> sources, List<Entity> targets)
    {
        Sources = sources;
        Targets = targets;

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