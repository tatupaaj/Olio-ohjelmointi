using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            while (true)
            {
                Console.WriteLine("Kirjoita luku");
                int luku = int.Parse(Console.ReadLine());
                summa = summa + luku;
                if (luku == 0)
                    break;
            }
            Console.WriteLine("Summa: " + summa);
        }
    }
}
