using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("сможешь дописать фамилии ?");

            string[] names = {"Peter","Tony","Klint","Natasha","Steve"};

            foreach(string i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            string[] surnames = new string[5];
            surnames[0] = Console.ReadLine();
            surnames[1] = Console.ReadLine();
            surnames[2] = Console.ReadLine();
            surnames[3] = Console.ReadLine();
            surnames[4] = Console.ReadLine();

            if (surnames[0] == "Parker" && surnames[1] == "Stark" && surnames[2] == "Barton" && surnames[3] == "Romanof" && surnames[4] == "Rogers")
                Console.WriteLine("правильно");
                else Console.WriteLine("ну ты и лох");

        }
    }
}