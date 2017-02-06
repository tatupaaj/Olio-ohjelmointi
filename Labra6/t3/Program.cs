using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cards;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKortit();
        }
        static void TestaaKortit()
        {
            Hertta[] hertta = new Hertta[13];
            Ruutu[] ruutu = new Ruutu[13];
            Risti[] risti = new Risti[13];
            Pata[] pata = new Pata[13];
            for (int i = 0; i < 13; i++)
            {
                hertta[i] = new Hertta { Nimi = "Hertta", Numero = i + 1 };
                ruutu[i] = new Ruutu { Nimi = "Ruutu", Numero = i + 1 + 13 };
                risti[i] = new Risti { Nimi = "Risti", Numero = i + 1 + 26 };
                pata[i] = new Pata { Nimi = "Pata", Numero = i + 1 + 39 };
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(hertta[i].ToString() + (i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(ruutu[i].ToString() + (i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(risti[i].ToString() + (i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(pata[i].ToString() + (i + 1));
            }
        }
    }
}
