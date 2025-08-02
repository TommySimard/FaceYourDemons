using System.Collections.Generic;
using System.Linq;

public class Combat
{
    public List<Turn> Rounds { get; private set; }
    public EnemyParty EnemyParty { get; private set; }
    public CombatMenu SkillMenu { get; private set; }
    public CombatStatus Status { get; private set; } = CombatStatus.InProgress;

    public Combat(HeroParty heroParty, EnemyParty enemyParty)
    {
        AddTurn();
    }

    private void AddTurn()
    {
        
    }

    private void IncrementRound()
    {
        
    }
}
