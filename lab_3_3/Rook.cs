using System;
using System.Diagnostics;

namespace lab_3_3
{
    internal class Rook : Thug
    {
        public Rook()
        {
        }

        public Rook(string name, string shipName, string rank, string shipType) : base(name, shipName, rank) => ShipType = shipType;

        public string ShipType { get; set; }

        public override void Information()
        {
            Console.WriteLine($"\nName: {Name}\nShip: '{ShipName}'\nRank: '{Rank}'\nТип корабля: {ShipType}\n");
            Debug.WriteLine($"Rook: Ім'я {Name}\nShip: '{ShipName}'\nRank: '{Rank}'\nShip type: {ShipType}\n");
        }
    }
}