using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int k = rnd.Next(0, 100);
            int i = 1;
            while (true)
            {
                Console.WriteLine("Arvaa luku:");
                int l = Int32.Parse(Console.ReadLine());
                if (k == l)
                {
                    Console.WriteLine("Hienoa, arvasit luvun " + i + " kerralla");
                    Console.WriteLine("");
                    break;
                }
                else if (l < k)
                    Console.WriteLine("Luku on pienempi");
                else
                    Console.WriteLine("Luku on isompi");
                i++;
            }
        }
    }
}
