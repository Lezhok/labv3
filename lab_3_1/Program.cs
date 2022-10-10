using System;

namespace Lab_3_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Creature creature = new("Lex", 3, "male", "dog");
        Console.WriteLine(creature);

        Dog dog = new("Тихон", 6, "male", "cat", "black");
        Console.WriteLine(dog);

        Creature abstractCreature = dog;
        Console.WriteLine(abstractCreature);

        Dog? dog1 = abstractCreature as Dog;
        Console.WriteLine(dog1);

        Console.ReadLine();
    }
}