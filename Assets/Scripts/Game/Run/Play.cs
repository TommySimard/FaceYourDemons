public struct Play
{
    public Skill UsedSkill { get; private set; }

    public Play(Skill usedSkill)
    {
        UsedSkill = usedSkill;
    }
}