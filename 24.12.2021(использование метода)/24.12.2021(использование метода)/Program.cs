using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            byte[] nums = { 5, 7, 8, 3, 5 };
            byte res1 = Summa(nums);
            Console.WriteLine("Результат:" + res1);

            byte[] nums1 = { 5, 3, 8, 3, 5 };
            byte res2 = Summa(nums1);
            Console.WriteLine("Результат:" + res2);
        }

        public static byte Summa(byte[] digits)
        {
            byte summ = 0;
            foreach (byte el in digits)
                summ += el;

            return summ;
        }

    }
}