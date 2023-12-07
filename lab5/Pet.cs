using System.Drawing;
using System.Xml.Linq;

namespace lab5;

public class Pet
{
    private PetInfo _petInfo;
    private int _childCount;

    public int ChildCount
    {
        get => _childCount; 
        set => _childCount = value;
    }
    public Pet(string name, string color, string breed, int age, int limbs, int childCount)
    {
        _petInfo = new PetInfo(name, color, breed, age, limbs);
        ChildCount = childCount;
    }
    public override string ToString()
    {
        return _petInfo.ToString() + $"\nChildCount - {ChildCount}";
    }
}