namespace lab5;

public class Dog : Pet
{
    private int _height;
    private int _tailLength;
    private bool _knowlageCommands;

    public int Height
    {
        get => _height;
        set => _height = value > 0 && value < 1000 ? value : throw new ArgumentOutOfRangeException();
    }
    public int TailLength
    {
        get => _tailLength;
        set => _tailLength = value;
    }
    public bool KnowlageCommands
    {
        get => _knowlageCommands;
        set => _knowlageCommands = value;
    }
    public Dog(string name, string color, string breed, int age, int limbs, int childCount, int height, int tailLength, bool knowlageCommands) : base(name, color, breed, age, limbs, childCount)
    {
        Height = height;
        TailLength = tailLength;
        KnowlageCommands = knowlageCommands;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nHeight - {Height}\nTail Length - {TailLength}\nKnowlage of Commands - {KnowlageCommands}";
    }
}
