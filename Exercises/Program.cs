using System;


namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num;
            Console.WriteLine("Упражнение 1\nПрограмма определит возрастает ли последовательность или нет.\nВведите первое число последовательности\n");
            bool flag = true;
            int[] nums = new int[10];
            do
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if(i > 0 && nums[i] < nums[i - 1])
                {

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
                if (flag1 == false || (num < 6 || num > 14))
                {
                    Console.WriteLine("Введите целое число от 6 до 14\n");
                    while (flag1 == false || (num < 6 || num > 14))

                    {
                        Console.WriteLine("Введите целое число от 6 до 14\n");
                        flag1 = int.TryParse(Console.ReadLine(), out num);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
