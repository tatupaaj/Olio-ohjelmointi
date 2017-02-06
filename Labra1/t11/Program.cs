using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita luku:");
            int luku = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= luku; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}