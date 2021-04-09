using System;

namespace oopCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto auto = new(20)
            {
            };
            auto.Kiihdytä();
            auto.Kiihdytä();
            auto.Kiihdytä();
            auto.Kiihdytä();
            auto.Kiihdytä();


            Console.WriteLine(auto.Nopeus);
        }
    }
}
