using System;

namespace TasK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
            {
                Console.WriteLine("7-e bolunur");

            }
            else
            {
                Console.WriteLine(devide(number));
            }

        }
        public static int devide(int num)
        {
            int small = num % 7;
            int big = 7 - small;
            if (small > big)
            {
                return num + big;
            }
            else
            {
                return num - small;
            }
        }
    }
}
