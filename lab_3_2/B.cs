using System;

namespace lab_3_2
{
    internal class B
    {
        public B()
        {
        }

        public B(string country, string city, DateTime cityTime)
        {
            City = city;
            Country = country;
            CityTime = cityTime;
        }

        public string City { get; set; }
        public DateTime CityTime { get; set; }
        public string Country { get; set; }


        public virtual void Time()
        {
            Console.WriteLine($"{City}: {CityTime.ToShortTimeString()}");
        }

        public virtual void ShortDate()
        {
            Console.WriteLine($"{City}: {CityTime.ToShortDateString()}");
        }

        public virtual void LongDate()
        {
            Console.WriteLine($"{City}: {CityTime.ToLongDateString()}");
        }
    }
}