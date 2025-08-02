public struct Stat
{
    public StatName Name { get; private set; }
    public int Min { get; private set; }
    public int Max { get; private set; }
    public int Value { get; private set; }

    public Stat(StatName name, int min, int max, int value)
    {
        Name = name;
        Min = min;
        Max = max;
        Value = value;
    }

    public Stat(Stat stat)
    {
        Name = stat.Name;
        Min = stat.Min;
        Max = stat.Max;
        Value = stat.Value;
    }

    public void SetValue(int value)
    {
        Value = value;
    }
}