using System;

namespace lab_3_4
{
    internal static class Program
    {
        private static int Age()
        {
            int age;
            Console.Write("Вкажіть Ваш вік: ");
            do
            {
                age = int.Parse(Console.ReadLine() ?? 5.ToString());
                if (age <= 0)
                {
                    Console.Write("Вкажіть справжній вік: ");
                }
            } while (age <= 0);

            return age;
        }

        private static double Weight()
        {
            double weight;
            Console.Write("Вкажіть Вашу вагу (використовуйте ',' замість '.'): ");
            do
            {
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.Write("Вкажіть справжню вагу: ");
                }
            } while (weight <= 0);

            return weight;
        }

        private static double Height()
        {
            double height;
            Console.Write("Вкажіть Ваш ріст (використовуйте ',' замість '.'): ");
            do
            {
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.Write("Вкажіть справжній ріст: ");
                }
            } while (height <= 0);

            return height;
        }

        private static string Gender()
        {
            string gender;
            Console.Write("Вкажіть Вашу стать (male, female): ");
            gender = Console.ReadLine();
            return gender;
        }

        private static int Activity()
        {
            Console.WriteLine("\nКод активності:\n1 - Якщо у Вас немає фізичних нагрузок і сидяча работа\n" +
                              "2 - Якщо Ви робите невеликі пробіжки абл робите легку гімнастику 1–3 рази в тиждень\n" +
                              "3 - Якщо Ви займаєтесь спортом із середніми нагрузками 3–5 рази в тиждень\n" +
                              "4 - Якщо Ви повноцінно тренуетесь 6–7 разів в тиждень\n" +
                              "5 - Якщо Ваша работа пов'язана с фізичною працею, Ви тренуетесь 2 рази в день і включаєте в програму тренувань силові вправи\n");
            Console.Write("Вкажіть Вашу активність: ");
            var activity = int.Parse(Console.ReadLine() ?? 5.ToString());
            return activity;
        }

        private static void Main(string[] args)
        {
            Console.Write("Активуйте ключ програми: ");
            var key = Console.ReadLine();
            AppLicense client = new AppLicense();
            int age = 0, activity = 0;
            double weight = 0, height = 0;
            switch (key)
            {
                case "pro":
                    client.AllowActivated();

                    break;

                case "trial":
                    client.AllowTrial();

                    break;

                case "":
                    client.AllowCommon();

                    break;

                default:
                    Console.WriteLine("Вам відмовлено в доступі до програми");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Відмінно! Приступимо до вводу Ваших параметрів.");
            age = Age();
            weight = Weight();
            height = Height();
            var gender = Gender();
            activity = Activity();
            Console.WriteLine();
            switch (key)
            {
                case "pro":
                {
                    Pro stud = new Pro(age, weight, height, gender, activity);
                    stud.WarmUp();
                    stud.Bmi();
                    stud.Calories();
                    break;
                }

                case "trial":
                {
                    Trial stud = new Trial(age, weight, height, gender, activity);
                    stud.WarmUp();
                    stud.Bmi();
                    stud.Calories();
                    break;
                }

                default:
                {
                    Common stud = new Common(age, weight, height, gender, activity);
                    stud.WarmUp();
                    stud.Bmi();
                    stud.Calories();
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}