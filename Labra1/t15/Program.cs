using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita luku:");
            int luku = Int32.Parse(Console.ReadLine());
            int n = 1;
            for (int i = 0; i < luku - 2; i++)
            {
                for (int k = luku - 3; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                n = n + 2;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int k = luku - 3; k >= 0; k--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }
        }
    }
}
