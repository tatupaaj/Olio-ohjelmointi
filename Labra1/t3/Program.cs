using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kirjoita luku:");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kirjoita toinen luku:");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kirjoita kolmas luku:");
            int l3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kirjoita toinen luku:");
            int summa = l1 + l2 + l3;
            float keskiarvo = (l1 + l2 + l3) / 3;
            Console.Write("Lukujen summa on: ");
            Console.Write(summa);
            Console.WriteLine(" ");
            Console.Write("Lukujen keskiarvo on: ");
            Console.Write(keskiarvo);
            Console.WriteLine(" ");
        }
    }
}
