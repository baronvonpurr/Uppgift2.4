using System;

namespace Uppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adderat blir det " + (tal1 + tal2));
            Console.WriteLine("Multiplicerat blir det " + (tal1 * tal2));
            Console.ReadKey();
        }
    }
}