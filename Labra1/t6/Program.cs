using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kirjoita matkaa (km):");
                string text = Console.ReadLine();
                if (text == "exit" || text == "x")
                    break;
                double hinta = 1.595;
                double km = Convert.ToInt32(text);
                double bensa = 7.02 / 100 * km;
                Console.WriteLine("Bensaa kuuluu " + bensa + " litraa, kustannus " + bensa * hinta);
            }
        }
    }
}
