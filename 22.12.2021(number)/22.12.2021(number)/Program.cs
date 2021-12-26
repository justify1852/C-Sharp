using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("я загадал число, если отгадаешь его, то ты молодец(это число больше 20, но меньше 30)");//27
            short number = Convert.ToInt16(Console.ReadLine());
            if (number != 27 && number >= 25)
            {
                Console.WriteLine("очень близко, но нет, поробуй еще раз");
                short number2 = Convert.ToInt16(Console.ReadLine());
                if (number2 == 27)
                {
                    Console.WriteLine("да, как ты угадал ?");
                }
                else if (number2 < 20 || number2 > 30)
                {
                    Console.WriteLine("дебил, я загадал число между 20 и 30");
                }
                else
                    Console.WriteLine("к сожелению, нет. В следующий раз повезет");
            }
            else if (number < 20 || number > 30)
            {
                Console.WriteLine("дебил, я загадал число между 20 и 30");
            }
            if (number == 27)
            {
                Console.WriteLine("да, как ты угадал ?");
            }
            else if (number != 27 && number < 25 && number > 20)
            {
                Console.WriteLine("холодно, попробуй число побольше");
                short number3 = Convert.ToInt16(Console.ReadLine());
                if (number3 == 27)
                {
                    Console.WriteLine("да, как ты угадал ?");
                }
                else if (number3 < 20 || number3 > 30)
                {
                    Console.WriteLine("дебил, я загадал число между 20 и 30");
                }
                else
                    Console.WriteLine("к сожелению, нет. В следующий раз повезет");
            }
        }
    }
}