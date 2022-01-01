using System;
namespace project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("выберите какую валюту хотите конвертировать (USD, RUB, EUR)");
            string first = Console.ReadLine();
            Console.WriteLine("выберите в какую валюту конвертировать " + first);
            string second = Console.ReadLine();
            Console.Write($"сколько {first} хотите конвертировать: ");
            double amount = Convert.ToSingle(Console.ReadLine());

            double rubleToUsd = amount * 2.5;
            double usdToRuble = amount / 2.5;
            double usdToEur = amount * 0.88;
            double euroTousd = amount / 0.88;
            double rubToEuro = amount / 3;
            double euroToRub = amount * 3;


            if (first == "USD" && second == "RUB")
            {
                double unswer1 = rubleToUsd;
                Console.WriteLine($"это будет {unswer1} {second} ");
            }
            else if (first == "RUB" && second == "USD")
            {
                double unswer2 = usdToRuble;
                Console.WriteLine($"это будет {unswer2} {second} ");
            }
            else if (first == "USD" && second == "EUR")
            {
                double unswer3 = usdToEur;
                Console.WriteLine($"это будет {unswer3} {second} ");
            }
            else if (first == "EUR" && second == "USD")
            {
                double unswer4 = euroTousd;
                Console.WriteLine($"это будет {unswer4} {second} ");
            }
            else if (first == "RUB" && second == "EUR")
            {
                double unswer5 = rubToEuro;
                Console.WriteLine($"это будет {unswer5} {second} ");
            }
            else if (first == "EUR" && second == "RUB")
            {
                double unswer6 = euroToRub;
                Console.WriteLine($"это будет {unswer6} {second} ");
            }
            else
                Console.WriteLine("ты наверное,что то не то указал!");


        }
    }
}
