using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 4\nСовмещены 4.1, 4.2, 4.3\n" +
                "Сделать программу получающую на вход число и выводящую число и месяц года\n" +
                "Введите год, целое число\n");
            int day, year;
            Console.WriteLine("Введите год:\n");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы не ввели целое число, повторите\n");
                bool year_flag = int.TryParse(Console.ReadLine(), out year);
                if (year_flag == false)
                {
                    while (year_flag == false)
                    {
                        Console.WriteLine("Вы не ввели целое число, повторите\n");
                        year_flag = int.TryParse(Console.ReadLine(), out year);
                    }

                }
            }

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Введите число от 1 до 366, високосный год\n");
                try
                {
                    day = Convert.ToInt32(Console.ReadLine());
                    bool flag = int.TryParse(Console.ReadLine(), out day);
                    if (day < 1 || day > 366)
                    {
                        Console.WriteLine("Введите целое число от 1 до 365\n");
                        while (flag == false || (day < 1 || day > 366))
                        {
                            Console.WriteLine("Введите целое число от 1 до 366\n");
                            flag = int.TryParse(Console.ReadLine(), out day);
                        }
                    }
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Введите целое число от 1 до 366\n");
                    bool flag = int.TryParse(Console.ReadLine(), out day);
                    if (flag == false || (day < 1 || day > 366))
                    {
                        Console.WriteLine("Введите целое число от 1 до 365\n");
                        while (flag == false || (day < 1 || day > 366))
                        {
                            Console.WriteLine("Введите целое число от 1 до 366\n");
                            flag = int.TryParse(Console.ReadLine(), out day);
                        }
                    }
                }
                
                if (day < 32)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day} {Months.January}");
                }
                else if (day >= 32 && day < 61)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 31} {Months.February}");
                }
                else if (day >= 61 && day < 92)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 60} {Months.March}");
                }
                else if (day >= 92 && day < 122)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 91} {Months.April}");
                }
                else if (day >= 122 && day < 153)
                {
                    Console.WriteLine($"Номеру  {day} соответсвует {day - 121} {Months.May}");
                }
                else if (day >= 153 && day < 183)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 152} {Months.June}");
                }
                else if (day >= 183 && day < 214)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 182} {Months.July}");
                }
                else if (day >= 214 && day < 245)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 213} {Months.August}");
                }
                else if (day >= 245 && day < 275)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 244} {Months.September}");
                }
                else if (day >= 275 && day < 306)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 274} {Months.October}");
                }
                else if (day >= 306 && day < 336)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 305} {Months.November}");
                }
                else
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 335} {Months.December}");
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 365\n");
                try
                {
                    day = Convert.ToInt32(Console.ReadLine());
                    bool flag = int.TryParse(Console.ReadLine(), out day);
                    if (day < 1 || day > 365)
                    {
                        Console.WriteLine("Введите целое число от 1 до 365\n");
                        while (flag == false || (day < 1 || day > 365))
                        {
                            Console.WriteLine("Введите целое число от 1 до 365\n");
                            flag = int.TryParse(Console.ReadLine(), out day);
                        }
                    }
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Введите целое число от 1 до 365\n");
                    bool flag = int.TryParse(Console.ReadLine(), out day);
                    if (flag == false || (day < 1 || day > 365))
                    {


                        Console.WriteLine("Введите целое число от 1 до 365\n");
                        while (flag == false || (day < 1 || day > 365))
                        {
                            Console.WriteLine("Введите целое число от 1 до 365\n");
                            flag = int.TryParse(Console.ReadLine(), out day);
                        }
                    }
                }

                if (day < 32)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day} {Months.January}");
                }
                else if (day >= 32 && day < 60)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 31} {Months.February}");
                }
                else if (day >= 60 && day < 91)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 59} {Months.March}");
                }
                else if (day >= 91 && day < 121)
                {
                    Console.WriteLine($"Номеру  {day} соответсвует {day - 90} {Months.April}");
                }
                else if (day >= 121 && day < 152)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 120} {Months.May}");
                }
                else if (day >= 152 && day < 182)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 151} {Months.June}");
                }
                else if (day >= 182 && day < 213)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 181} {Months.July}");
                }
                else if (day >= 213 && day < 244)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 212} {Months.August}");
                }
                else if (day >= 244 && day < 274)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 243} {Months.September}");
                }
                else if (day >= 274 && day < 305)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 273} {Months.October}");
                }
                else if (day >= 305 && day < 335)
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 304} {Months.November}");
                }
                else
                {
                    Console.WriteLine($"Номеру {day} соответсвует {day - 334} {Months.December}");
                }
            }

            Console.ReadKey();
        }
    }
}
