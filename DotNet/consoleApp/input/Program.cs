﻿using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello {input}!");
        }
    }
}
