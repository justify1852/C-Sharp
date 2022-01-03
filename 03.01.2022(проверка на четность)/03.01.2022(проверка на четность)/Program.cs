using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число ");

            double number = Convert.ToDouble(Console.ReadLine());

            if(number % 2 != 0)
            {
                Console.WriteLine("это нечетное число");
            }
            else
            {
                Console.WriteLine("это четное число");
            }
        }
    }
}