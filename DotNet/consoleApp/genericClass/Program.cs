using System;
using System.Collections.Generic;

namespace genericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> merkkijonot = new List<string>();

            merkkijonot.Add("testi");
            merkkijonot.Add("testi2");
            merkkijonot.Add("testi3");


            merkkijonot.Remove("testi"); // remove testi
            merkkijonot.RemoveAt(1); // remove index 1

            foreach (string merkkijono in merkkijonot){
                Console.WriteLine(merkkijono);
            };


            Auto a1 = new()
            {
                Merkki = "Toyota",
                Malli = "Corolla",
                Huippunopeus = 190
            };
            Auto a2 = new()
            {
                Merkki = "Audi",
                Malli = "A4",
                Huippunopeus = 230
            };

            List<Auto> autot = new();
            autot.Add(a1);
            autot.Add(a2);

            foreach (Auto auto in autot)
            {
                Console.WriteLine(auto.Merkki);
            }
        }
    }
}
