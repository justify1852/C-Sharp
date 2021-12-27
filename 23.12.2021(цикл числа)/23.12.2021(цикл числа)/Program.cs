using System;
namespace project
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)

                    continue;

                Console.WriteLine($"четное число {i}");
            }
            Console.WriteLine();
            for (int y = 1; y <= 20; y++)
            {
                if (y % 2 == 0)

                    continue;

                Console.WriteLine($"нечетное число {y} ");
            }

        }
    }
}
