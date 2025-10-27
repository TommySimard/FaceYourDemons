public class Turn
{
    public readonly Entity Actor;
    public readonly Skill Action;

    public Turn(Entity actor, Skill action)
    {
        Actor = actor;
        Action = action;
    }

    public void Execute()
    {
        Actor.UseSkill(Action);
    }
}