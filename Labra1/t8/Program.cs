using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l = new int[3];
            Console.WriteLine("Kirjoita ensimmainen luku:");
            l[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoita toinen luku:");
            l[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoita kolmas luku:");
            l[2] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (l[i] < l[j])
                        l[i] = l[j];
                }
            }
            Console.WriteLine("Suurin luku on " + l[0]);
        }
    }
}
