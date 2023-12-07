namespace lab5;
public class Pets
{
    private Pet[] _pets;

    public Pets()
    {
        _pets = _pets = _pets = Array.Empty<Pet>();
    }
    public Pets(params Pet[] pets)
    {
        _pets = pets;
    }

    public void AddPet(Pet pet)
    {
        Array.Resize(ref _pets, _pets.Length + 1);
        _pets[^1] = pet;
    }
    public void DeletePet(int n)
    {
        var tmp = new List<Pet>(_pets); // Преобразование в список
        tmp.RemoveAt(n); // Удаление элемента
        var b = tmp.ToArray();
        _pets = b;
    }
    public void ChangePet(int n, Pet pet)
    {
        _pets[n] = pet;
    }
    public override string ToString()
    {
        string outputStr = "";
        for (int i = 0; i < _pets.Length; i++)
        {
            outputStr += $"{i}: \n{_pets[i].ToString()}\n\n";
        }
        return outputStr;
    }
}

