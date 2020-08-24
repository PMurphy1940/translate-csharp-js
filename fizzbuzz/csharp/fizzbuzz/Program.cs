using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count < 101; count++)
            {
                if (count % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine($"{count}");
                }
            }
        }
    }
}
