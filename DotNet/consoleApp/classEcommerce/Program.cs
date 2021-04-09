using System;

namespace classEcommerce
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Asiakas asiakas = new()
            {
                Name = "matti meikäläinen",
                Address = "osoitekatu 123",
                Tel = "0404123456",
                Email = "matti@hotmail.fi"
            };

            Tilaus tilaus = new Tilaus();
            tilaus.Date = DateTime.Today;
            tilaus.ProductName = "puhelin";
            tilaus.Amount = 1;

            Console.WriteLine(asiakas.Name);
            Console.WriteLine(tilaus.ProductName);

        }
    }
}
