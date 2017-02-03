using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kirjoita pisteitta 0-12:");
                string valinta = Console.ReadLine();
                if (valinta == "exit" || valinta == "x")
                    break;
                else if (valinta == "0" || valinta == "1")
                {
                    Console.WriteLine("Saat 0");
                }
                else if (valinta == "2" || valinta == "3")
                {
                    Console.WriteLine("Saat 1");
                }
                else if (valinta == "4" || valinta == "5")
                {
                    Console.WriteLine("Saat 2");
                }
                else if (valinta == "6" || valinta == "7")
                {
                    Console.WriteLine("Saat 3");
                }
                else if (valinta == "8" || valinta == "9")
                {
                    Console.WriteLine("Saat 4");
                }
                else if (valinta == "10" || valinta == "11" || valinta == "12")
                {
                    Console.WriteLine("Saat 5");
                }
                else
                    Console.WriteLine("Wrong input!");
            }
        }
    }
}
