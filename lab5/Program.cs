using lab5;

internal class Program
{
    public static void Main(string[] args)
    {
        Cat Myrka = new Cat("Myrka", "Brown", "Strit", 15, 4, 8, 24, 20, "Green");
        Dog Borman = new Dog("Borman", "Black", "Strit", 5, 4, 0, 53, 30, false);
        Parrot Kesha = new Parrot("Kesha", "Yeallow-Green", "Wave Parrot", 3, 4, 0, 15, 2, false);

        Pets pets = new Pets(); 

        pets.AddPet(Myrka);
        pets.AddPet(Borman);
        pets.AddPet(Kesha);
        Console.WriteLine(pets);

        pets.DeletePet(1);
        Console.WriteLine(pets);

        Parrot Gosha = new Parrot("Gosha", "Yeallow", "Ara", 5, 4, 0, 30, 7, true);

        pets.ChangePet(1, Gosha);
        Console.WriteLine(pets);
    }
}