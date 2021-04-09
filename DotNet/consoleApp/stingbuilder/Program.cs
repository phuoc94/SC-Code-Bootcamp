using System;
using System.Text;

namespace stingbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime alku = DateTime.Now;
            StringBuilder html = new("<table>");
            for (int i = 0; i < 1000000; i++)
            {
                html.Append( "<tr><td>" + i + "</td></tr>\r\n");
            }
            html.Append("</table>");
            Console.WriteLine("HTML-koodin pituus: " + html.Length);
            DateTime loppu = DateTime.Now;

            TimeSpan kesto = loppu - alku;
            Console.WriteLine($"HTML-koodin muodostus kesti: {kesto.TotalSeconds}.");
        }
    }
}
