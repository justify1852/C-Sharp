using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("напиши год рождения и я скажу возраст");

            int dateOfBorn = Convert.ToInt32(Console.ReadLine());
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string year = currentDate.Substring(0, 4);
            int convertYear = Convert.ToInt32(year);
            int unswer = convertYear - dateOfBorn;

            Console.WriteLine("возраст " + unswer + " лет");
        }
    }
}