using System;
using System.Diagnostics;

namespace lab_3_2
{
    internal class B2 : B
    {
        public B2(string country, string city, DateTime cityTime) : base(country, city, cityTime)
        {
        }

        public override void ShortDate()
        {
            Console.WriteLine($"{City}: {CityTime.ToLongDateString()}");
            Debug.WriteLine($"{Country}, {City}, {CityTime}\n");
        }
    }
}