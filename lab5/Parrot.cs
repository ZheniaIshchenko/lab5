namespace lab5;

public class Parrot : Pet
{
    private int _wingspan;
    private int _beakLength;
    private bool _speak;

    public int Wingspan
    {
        get => _wingspan;
        set => _wingspan = value > 0 && value < 1000 ? value : throw new ArgumentOutOfRangeException();
    }
    public int BeakLength
    {
        get => _beakLength;
        set => _beakLength = value;
    }
    public bool Speak
    {
        get => _speak;
        set => _speak = value;
    }
    public Parrot(string name, string color, string breed, int age, int limbs, int childCount, int winspan, int beakLeangth, bool speak) : base(name, color, breed, age, limbs, childCount)
    {
        Wingspan = winspan;
        BeakLength = beakLeangth;
        Speak = speak;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nWingspan - {Wingspan}\nBeak Length - {BeakLength}\nCan Speak - {Speak}";
    }
}
