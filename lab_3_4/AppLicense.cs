using System;

namespace lab_3_4
{
    internal class AppLicense
    {
        public AppLicense()
        {
        }

        public AppLicense(int age, double weight, double height, string gender, int activity)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            Activity = activity;
        }

        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Gender { get; set; }
        public int Activity { get; set; }

        public void AllowTrial()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trial період");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void AllowCommon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Free version");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void AllowActivated()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Activated");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public virtual void WarmUp()
        {
            Console.WriteLine("\t\t\tРозминка");
            Console.WriteLine(
                "1. Кругові оберти головою (по 5 в різні сторони)\n" +
                "2. Круги руками (по 5 кругів в різні сторони)\n" +
                "3. Нахили з руками за головою (10 раз)\n" +
                "4. Помахи руками (по 10 раз в різні сторони)\n" +
                "5. Глибокий нахил в сторону(по 5 в кожну сторону)\n" +
                "6. Присідання (15 раз)\n" +
                "7. Віджимання (20 раз)\n");
        }

        public virtual void Bmi()
        {
            if (Age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Даная формула може показувати помилковий індекс для дітей");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            var result = Weight / (Height * Height) * 10000;
            Console.Write("Ваш індекс маси тіла: ");

            if (result <= 16)
            {
                Console.WriteLine($"{result} - виражений дефіцит маси тіла");
            }
            else if (result > 16 && result <= 18.5)
            {
                Console.WriteLine($"{result} - дефіцит маси тіла");
            }
            else if (result > 18.5 && result <= 25)
            {
                Console.WriteLine($"{result} - нормальна маса тіла");
            }
            else if (result > 25 && result <= 30)
            {
                Console.WriteLine($"{result} - надлишкова маса тіла");
            }
            else if (result > 30 && result <= 35)
            {
                Console.WriteLine($"{result} - ожиріння");
            }
            else if (result > 35 && result <= 40)
            {
                Console.WriteLine($"{result} - різке ожиріння");
            }
            else if (result > 40)
            {
                Console.WriteLine($"{result} - дуже різке ожиріння");
            }
        }

        public virtual void Calories()
        {
            double calories = 0;
            if (Gender == "male" || Gender == "Male")
            {
                switch (Activity)
                {
                    case 1:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age + 5);
                        break;

                    case 2:
                        calories = 1.375 * (10 * Weight + 6.25 * Height - 5 * Age + 5);
                        break;

                    case 3:
                        calories = 1.55 * (10 * Weight + 6.25 * Height - 5 * Age + 5);
                        break;

                    case 4:
                        calories = 1.725 * (10 * Weight + 6.25 * Height - 5 * Age + 5);
                        break;

                    case 5:
                        calories = 1.9 * (10 * Weight + 6.25 * Height - 5 * Age + 5);
                        break;

                    default:
                        calories = 10 * Weight + 6.25 * Height - 5 * Age + 5;
                        break;
                }

                Console.WriteLine($"Рекомендована кільеість калорій у день: {calories}");
            }
            else if (Gender == "female" || Gender == "Female")
            {
                switch (Activity)
                {
                    case 1:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age - 161);
                        break;

                    case 2:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age - 161);
                        break;

                    case 3:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age - 161);
                        break;

                    case 4:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age - 161);
                        break;

                    case 5:
                        calories = 1.2 * (10 * Weight + 6.25 * Height - 5 * Age - 161);
                        break;

                    default:
                        calories = 10 * Weight + 6.25 * Height - 5 * Age - 161;
                        break;
                }

                Console.WriteLine($"Рекомендоваа кількість калорій у день: {calories}");
            }
            else
            {
                Console.WriteLine("На жаль, програма не рахує рекомендовані калорії для введеної статі. Ось формули:\n" +
                                  "Для жінок: коеф.активності * ((10 × вага в кілограмах) + (6,25 × ріст в сантиметрах) − (5 × вік в роках) − 161)\n" +
                                  "Для чоловіків: коеф.активності * ((10 × вага в кілограмах) + (6, 25 × ріст в сантиметрах) − (5 × вік в роках) +5)\n");
            }
        }
    }
}