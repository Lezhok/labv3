using System;
using System.Diagnostics;

namespace lab_3_3
{
    internal class Thug
    {
        protected Thug()
        {
        }

        public Thug(string name, string shipName, string rank)
        {
            Name = name;
            ShipName = shipName;
            Rank = rank;
        }

        public string Name { get; set; }
        public string ShipName { get; set; }
        public string Rank { get; set; }

        public virtual void Information()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Ship: {ShipName}");
            Console.WriteLine($"Rank: {Rank}");
            Debug.WriteLine($"Pirate: name - {Name}, ship -  '{ShipName}', rank -  '{Rank}'\n");
        }
    }
}