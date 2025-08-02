public struct Class
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EntityType Type { get; private set; }
    public Stats BaseStats { get; private set; }

    public Class(ClassSO classSO)
    {
        Name = classSO.name;
        Description = classSO.Description;
        Type = classSO.Type;
        BaseStats = new Stats(classSO.StatsSO);
    }
}