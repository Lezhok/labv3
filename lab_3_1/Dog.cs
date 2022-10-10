using System.Diagnostics;

namespace Lab_3_1;

internal class Dog : Creature
{
    public Dog()
    {
    }

    public Dog(string name, int age, string gender, string type, string breed) : base(name, age, gender, type)
    {
        Breed = breed;
    }
    public string Breed { get; set; }
    
}