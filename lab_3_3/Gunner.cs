using System;
using System.Diagnostics;

namespace lab_3_3
{
    internal class Gunner : Thug
    {
        public Gunner()
        {
        }

        public Gunner(string Name, string ShipName, string Rank, int cannons, string cannon_type) : base(Name, ShipName, Rank)
        {
            Cannons = cannons;
            CannonType = cannon_type;
        }

        public int Cannons { get; set; }
        public string CannonType { get; set; }

        public override void Information()
        {
            Console.WriteLine($"Ім'я {Name}\nКорабель '{ShipName}'\nПосада '{Rank}'\n" +
                              $"Кількість пушок в обслуговуванні: {Cannons}\nТип пушок: {CannonType}\n");
            Debug.WriteLine($"Клас Gunner: Ім'я {Name}\nкорабель '{ShipName}'\nПосада '{Rank}'\n" +
                            $"Кількість пушок в обслуговуванні: {Cannons}\nТип пушок: {CannonType}\n");
        }
    }
}