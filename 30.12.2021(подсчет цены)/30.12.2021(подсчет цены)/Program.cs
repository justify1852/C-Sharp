using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.Write("введите количество фильмов, которые вы посмотрели ");
            int amountOfFilms = Convert.ToInt32(Console.ReadLine());
            float month = 9.99f;

            if (amountOfFilms < 0)
                Console.WriteLine("вы вели не верное число ");

            if (amountOfFilms <= 10 && amountOfFilms > 0)

                Console.WriteLine("It will be cost you " + month);

            if (amountOfFilms > 10 && amountOfFilms <= 25)
            {
                float cost = (amountOfFilms - 10) * 1.5f + (month);

                Console.WriteLine("It will be cost you " + cost);

            }
            if (amountOfFilms > 25 && amountOfFilms <= 45)
            {
                float count_1 = amountOfFilms - 10;
                float count_2 = count_1 - 15;
                float sum_20 = (count_1 * 1.5f) + (count_2 * 3f) + (month);

                Console.WriteLine("It will be cost you " + sum_20);
            }
            if (amountOfFilms > 45)
            {
                float count_3 = amountOfFilms - 10;
                float count_4 = amountOfFilms - 15;
                float count_5 = count_4 - 20;

                double sum_45 = (count_3 * 1.5) + (count_4 * 3) + (count_5 * 1) + month;

                Console.WriteLine("It will be cost you " + sum_45);
            }
        }
    }
}