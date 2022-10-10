using System;

namespace lab_3_4
{
    internal class Trial : AppLicense
    {
        public Trial()
        {
        }

        public Trial(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }

        public override void WarmUp()
        {
            Console.WriteLine("Функціонал пробного періоду версії");
            base.WarmUp();
        }

        public override void Bmi()
        {
            Console.WriteLine("\nФункціонал пробного періоду");
            base.Bmi();
        }

        public override void Calories()
        {
            Console.WriteLine("\nФункціонал пробного періоду");
            base.Calories();
        }
    }
}