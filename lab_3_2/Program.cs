using System;

namespace lab_3_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            B city1 = new B("Україна", "Київ", DateTime.Now);
            B city2 = new B("Англія", "Лондон", DateTime.UtcNow);
            B city3 = new B("США", "Нью-Йорк", DateTime.UtcNow.AddHours(-3));
            B city4 = new B("Японія", "Токіо", DateTime.UtcNow.AddHours(9));
            B city5 = new B("Австралія", "Сідней", DateTime.UtcNow.AddHours(10));
            A a1 = new A(city1, city2, city3);
            a1.Time();
            A a2 = new A(city4, city5);
            a2.Time();

            Console.WriteLine("Передбачення методу LongDate:");
            city1.LongDate();
            B1 c1 = new B1(city1.Country, city1.City, city1.CityTime);
            c1.LongDate();

            Console.WriteLine("\nПередбачення методу ShortDate:");
            city2.ShortDate();
            B2 c2 = new B2(city2.Country, city2.City, city2.CityTime);
            c2.ShortDate();

            Console.WriteLine("\nПередбачення методу OnlyTime:");
            city3.Time();
            B3 c3 = new B3(city3.Country, city3.City, city3.CityTime);
            c3.Time();
            Console.ReadLine();
        }
    }
}