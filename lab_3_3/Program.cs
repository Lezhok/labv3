using System;

namespace lab_3_3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Thug thug = new Thug("Джон Сільвер", "Морж", "Квартирмейстер");
            thug.Information();

            Boss boss = new Boss("Джеймс Флінт", "Морж", "Капітан", 25, "Насау");
            boss.Information();

            Rook jack = new Rook("Джек Сміт", "Морж", "Плотник", "Бригантина");
            jack.Information();

            Gunner will = new Gunner("Вілл Тернер", "Морж", "Канонір", 32, "Бомбарда");
            will.Information();

            Console.ReadLine();

        }
    }
}