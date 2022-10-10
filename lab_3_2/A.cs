using System;

namespace lab_3_2
{
    internal class A
    {
        private readonly B _b1;
        private readonly B _b2;
        private readonly B _b3;

        public A()
        {
        }

        public A(B b1, B b2, B b3 = null)
        {
            _b1 = b1;
            _b2 = b2;
            _b3 = b3;
        }

        public void Time()
        {
            if (_b3 == null)
            {
                Console.WriteLine($"{_b1.Country}, {_b1.City}: {_b1.CityTime}");
                Console.WriteLine($"{_b2.Country}, {_b2.City}: {_b2.CityTime}\n");
            }
            else
            {
                Console.WriteLine($"{_b1.Country}, {_b1.City}: {_b1.CityTime}");
                Console.WriteLine($"{_b2.Country}, {_b2.City}: {_b2.CityTime}");
                Console.WriteLine($"{_b3.Country}, {_b3.City}: {_b3.CityTime}\n");
            }
        }
    }
}