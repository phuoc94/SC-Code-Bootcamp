using System;

namespace sumInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give 1. number?");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give 2. number?");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{first} + {second} = {first + second}");
        }
    }
}
