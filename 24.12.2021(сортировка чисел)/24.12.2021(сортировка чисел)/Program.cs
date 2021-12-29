using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = new List<double>()
            {
                23.3,1.8,2.5,1.87,
            };

            numbers.Sort();

            foreach(double i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}