using System;


namespace Exercises
{
    enum Week
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num = 0, weekday = 0, count = 0;
            Console.WriteLine("Упражнение 1\nПрограмма определит возрастает ли последовательность или нет.\nВводите подряд числа последовательности, через Enter\n");
            bool flag = true;
            int[] nums = new int[10];
            do
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if(i > 0 && nums[i] <= nums[i - 1])
                {
                    flag = false;
                    break;
                }
            }
            while (i++ < 9);
            Console.WriteLine(flag ? "Последовательность упорядочена\n" : $"Последовательность не упорядочена, сбилась на числе {nums[i]}\n");
            
            
            Console.WriteLine("Задание 2\nВведите номер от 6 до 14 а программа выдаст вам эквивалентную карту\n");

            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введите целое число от 6 до 14\n");
                bool flag1 = int.TryParse(Console.ReadLine(), out num);
                if (flag1 == false)
                {
                    Console.WriteLine("Введите целое число от 6 до 14\n");
                    while (flag1 == false)

                    {
                        Console.WriteLine("Введите целое число от 6 до 14\n");
                        flag1 = int.TryParse(Console.ReadLine(), out num);
                    }
                }
            }
            finally
            {
                switch(num)
                {
                    case 6:
                        Console.WriteLine("Ваша карта 6\n");
                        break;
                    case 7:
                        Console.WriteLine("Ваша карта 7\n");
                        break;
                    case 8:
                        Console.WriteLine("Ваша карта 8\n");
                        break;
                    case 9:
                        Console.WriteLine("Ваша карта 9\n");
                        break;
                    case 10:
                        Console.WriteLine("Ваша карта 10\n");
                        break;
                    case 11:
                        Console.WriteLine("Ваша карта Валет\n");
                        break;
                    case 12:
                        Console.WriteLine("Ваша карта Дама\n");
                        break;
                    case 13:
                        Console.WriteLine("Ваша карта Король\n");
                        break;
                    case 14:
                        Console.WriteLine("Ваша карта туз\n");
                        break;
                    default:
                        Console.WriteLine("Вы ввели число которому не принадлежит ни одна карта\n");
                        break;
                }
            }
            Console.WriteLine("Задание 3 - программа рекомендует вам алкогольный напиток\nКем вы являетесь?\n");
            string text = Console.ReadLine().ToLower();

            switch (text)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila\n");
                    break;
                case "school сounselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }
            
            Console.WriteLine("Задание 4 - выводит день недели, который соответствует данному числу\nВведите число от 1 до 7");

            try
            {
                weekday = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введите целое число от 1 до 7\n");
                bool weekflag = int.TryParse(Console.ReadLine(), out weekday);
                if (weekflag == false || (weekday < 1 || weekday > 7))
                {
                    Console.WriteLine("Введите целое число от 1 до 7\n");
                    while (weekflag == false || (weekday < 1 || weekday > 7))

                    {
                        Console.WriteLine("Введите целое число от 1 до 7\n");
                        weekflag = int.TryParse(Console.ReadLine(), out weekday);
                    }
                }
            }
            finally
            {
                switch(weekday)
                {
                    case 1:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Понедельник}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Вторник}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Среда}\n");
                        break;
                    case 4:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Четверг}\n");
                        break;
                    case 5:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Пятница}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Суббота}\n");
                        break;
                    case 7:
                        Console.WriteLine($"Вашему числу соответсвует {Week.Воскресенье}\n");
                        break;
                    default:
                        Console.WriteLine("Ваше число не соответсвует ни одному дню недели\n");
                        break;
                }
            }

            Console.WriteLine("Задание 5 - куколки\n");
            string[] dolls = new string[8] {"Barbie doll", "Default doll", "Hello Kitty", "Monster High", "Barbie doll", "Thug doll", "Finessin doll", "Hello Kitty"};
            
            foreach(string doll in dolls)
            {
                if(doll == "Barbie doll" || doll == "Hello Kitty")
                {
                    count++;
                }
            }
            Console.WriteLine($"Нужных нам кукол в массиве: {count}\n");

            Console.ReadKey();
        }
    }
}
