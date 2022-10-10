using System;
using System.Diagnostics;
using System.Text;

namespace Lab_3_1;

internal class Creature
{
    protected Creature()
    {
    }

    public Creature(string name, int age, string gender, string type)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Type = type;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Type { get; set; }

    /// <inheritdoc />
    public override string ToString() => $"Name: ({Name.GetType()}): {Name}Age: ({Age.GetType()}): {Age}Gender: ({Gender.GetType()}): {Gender}";
    
}