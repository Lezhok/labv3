using System;

namespace lab_3_4
{
    internal class Common : AppLicense
    {
        public Common(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }

        public override void WarmUp()
        {
            Console.WriteLine("Функціонал пробного періоду версії");
            base.WarmUp();
        }

        public override void Bmi()
        {
            Console.WriteLine("\nФункціонал безкоштовної версії");
            base.Bmi();
        }

        public override void Calories()
        {
            Console.WriteLine("\nФункціонал безкоштовної версії");
            double calories = 0;
            switch (Gender)
            {
                case "male":
                case "Male":
                    calories = 10 * Weight + 6.25 * Height - 5 * Age + 5;

                    Console.WriteLine($"Рекомендуемое количество калорий в день, не учитывая активность: {calories}");
                    break;

                case "female":
                case "Female":
                    calories = 10 * Weight + 6.25 * Height - 5 * Age - 161;

                    Console.WriteLine($"Рекомендована кількість калорій в день, не враховуючи активність: {calories}");
                    break;

                default:
                    Console.WriteLine("На жаль, програма не рахує рекомендовані калорії для введеної статі. Ось формули:\n" +
                                      "Для жінок: коеф.активності * ((10 × вага в кілограмах) + (6,25 × ріст в сантиметрах) − (5 × вік в роках) − 161)\n" +
                                      "Для чоловіків коеф.активності * ((10 × вага в кілограмах) + (6, 25 × ріст в сантиметрах) − (5 × вік в роках) +5)\n");
                    break;
            }
        }
    }
}