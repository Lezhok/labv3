using System;

namespace lab_3_4
{
    internal class Pro : AppLicense
    {
        public Pro(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }

        public override void WarmUp()
        {
            Console.WriteLine("Paid version");
            base.WarmUp();
        }

        public override void Bmi()
        {
            Console.WriteLine("Paid version");
            base.Bmi();
        }

        public override void Calories()
        {
            Console.WriteLine("Paid version");
            base.Calories();
        }
    }
}