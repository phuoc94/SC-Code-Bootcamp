using System;
using System.IO;
using System.Linq;
namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
        string text = File.ReadAllText(@"/home/kode/codebootcamp/DotNet/consoleApp/ReadFile/Numerot.txt");
        string[] words = text.Split('\n');
        int[] myInts = Array.ConvertAll(words, s => int.Parse(s));
        int sum = myInts.Sum();
        Console.WriteLine(sum);
        }
    }
}
