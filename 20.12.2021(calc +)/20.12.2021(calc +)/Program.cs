using System;

namespace project
{

    class Program
    {

        static void Main()
        {
            int num_1, num_2, equals;

            Console.Write("Это калькулятор, но он пока что умеет только складывать два числа, и то только целые числа.\nВведите первое число: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            equals = num_1 + num_2;
            Console.WriteLine($"{num_1} + {num_2} равно {equals}");

        }

    }

}
