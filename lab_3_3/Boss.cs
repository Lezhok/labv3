using System;
using System.Diagnostics;

namespace lab_3_3
{
    internal class Boss : Thug
    {
        public Boss()
        {
        }

        public Boss(string name, string shipName, string rank, int experience, string mainPort) : base(name, shipName, rank)
        {
            Experience = experience;
            MainPort = mainPort;
        }

        public int Experience { get; }
        public string MainPort { get; }

        public override void Information()
        {
            Console.WriteLine($"\n{Rank} корабля '{ShipName}' {Name}");
            Console.WriteLine($"Стаж: {Experience}\nПорт: {MainPort}");
            Debug.WriteLine($"Клас Captain: ім'я {Name}\nКорабель '{ShipName}'\nПосада '{Rank}'\n" +
                            $"Стаж: {Experience}\nПорт: {MainPort}\n");
        }
    }
}