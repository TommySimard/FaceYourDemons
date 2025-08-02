using System;
using System.Collections.Generic;

public class Skill
{
    private readonly Action<List<Entity>, List<Entity>> _use;

    public string Name { get; private set; }
    public string Description { get; private set; }

    public Skill(SkillSO skillSO)
    {
        _use = skillSO.Use;
        Name = skillSO.name;
        Description = skillSO.Description;
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