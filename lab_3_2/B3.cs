using System;
using System.Diagnostics;

namespace lab_3_2
{
    internal class B3 : B
    {
        public B3(string country, string city, DateTime cityTime) : base(country, city, cityTime)
        {
        }

        public override void Time()
        {
            Console.WriteLine($"{City}: {CityTime.ToLongTimeString()}");
            Debug.WriteLine($"{Country}, {City}, {CityTime}\n");
        }
    }
}