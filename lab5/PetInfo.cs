namespace lab5;

public class PetInfo
{
    private string _name;
    private string _color;
    private string _breed;
    private int _age;
    private int _limbs;


    public string Name
    {
        get => _name; 
        set => _name = value.Trim();
    }
    public string Color
    {
        get => _color;
        set => _color = value.Trim();
    }
    public string Breed
    {
        get => _breed;
        set => _breed = value.Trim();
    }
    public int Age
    {
        get => _age;
        set => _age = value > 0 ? value : throw new ArgumentOutOfRangeException();
    }
    public int Limbs
    {
        get => _limbs;
        set => _limbs = value > 0 ? value : throw new ArgumentOutOfRangeException();
    }

    public PetInfo(string name, string color, string breed, int age, int limbs)
    {
        Name = name;
        Color = color;
        Breed = breed;
        Age = age;
        Limbs = limbs;
    }
    public override string ToString()
    {
        return $"Name - {Name}\n" +
               $"Color - {Color}\n" +
               $"Breed - {Breed}\n" +
               $"Age - {Age}\n" +
               $"Limbs - {Limbs}";
    }
}