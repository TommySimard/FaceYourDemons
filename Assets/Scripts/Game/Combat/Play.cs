using System.Collections.Generic;

public class Play
{
    public Entity ActingEntity { get; private set; }
    public List<Skill> UsedSkill { get; private set; }
    public CombatStatus Status { get; private set; } = CombatStatus.InProgress;

    public Play()
    {
        
    }
}
