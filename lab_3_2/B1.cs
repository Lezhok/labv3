using System;
using System.Diagnostics;

namespace lab_3_2
{
    internal class B1 : B
    {
        public B1(string country, string city, DateTime cityTime) : base(country, city, cityTime)
        {
        }

        public override void LongDate()
        {
            Console.WriteLine($"{City}: {CityTime.ToUniversalTime()}");
            Debug.WriteLine($"{Country}, {City}, {CityTime}\n");
        }
    }
}