// See https://aka.ms/new-console-template for more information
using System;

namespace simpsonovi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] simpsonovi = { "Homer", "Marge", "Bart", "Lisa", "Magie" };
            Array.Sort(simpsonovi);
            foreach (string serazeno in simpsonovi)
                Console.WriteLine("{0}", serazeno);
            Console.ReadKey();
        }
    }
}
