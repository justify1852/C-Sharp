using System;

namespace project
{

    class Program
    {

        static void Main()
        {
            Console.Write("Введите ваш вес(кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост(м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double IMT = weight / (height * 2);
            Console.WriteLine($"Ваш индекс массы тела равен: {IMT}");
        }

    }
}