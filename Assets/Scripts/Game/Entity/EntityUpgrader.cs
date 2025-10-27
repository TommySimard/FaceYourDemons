using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityUpgrader : MonoBehaviour
{
    public Entity EntityToUpgrade { get; private set; }
    public List<Ability> AbilityChoices { get; private set; }
    public List<Skill> SkillChoices { get; private set; }
    public List<Stat> StatChoices { get; private set; }

    public void Init()
    {

    }
}
