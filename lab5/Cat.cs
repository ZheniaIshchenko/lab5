using System.Drawing;
using System.Xml.Linq;

namespace lab5;

public class Cat : Pet
{
    private int _height;
    private int _tailLength;
    private string _eyesColor;

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
    public string EyesColor
    {
        get => _eyesColor;
        set => _eyesColor = value;
    }
    public Cat(string name, string color, string breed, int age, int limbs, int childCount, int height, int tailLength, string eyesColor) : base(name, color, breed, age, limbs, childCount)
    {
        Height = height;
        TailLength = tailLength;
        EyesColor = eyesColor;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nHeight - {Height}\nTail Length - {TailLength}\nEye Color - {EyesColor}";
    }
}
