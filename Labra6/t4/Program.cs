using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using joukkue;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaJoukkue();
        }

        static void TestaaJoukkue()
        {
            Joukkue joukkue = new Joukkue { Nimi = "JYP", Kotikaupunki = "Helsinki" };
            Pelaaja[] p = new Pelaaja[6];
            int m = 0;
            while (true)
            {
                Console.WriteLine("Kirjoita valinta 0(Jos haluat mennä pois), 1(Jos haluat lisätä pelaajan), 2(Jos haluat poistaa pelaajan), 3(Jos haluat nähdä pelaajanlista)");
                int valinta = Int32.Parse(Console.ReadLine());
                if (valinta == 0)
                    break;
                else
                {
                    if (valinta == 1)
                    {
                        Console.WriteLine("Kirjoita etunimi:");
                        string etunimi = Console.ReadLine();
                        Console.WriteLine("Kirjoita sukunimi:");
                        string sukunimi = Console.ReadLine();
                        Console.WriteLine("Kirjoita ika:");
                        int ika = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Kirjoita numero:");
                        int numero = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Kirjoita rooli:");
                        string rooli = Console.ReadLine();
                        p[m] = new Pelaaja { Etunimi = etunimi, Sukunimi = sukunimi, Ika = ika, Numero = numero, Rooli = rooli };
                        joukkue.LisaaPelaaja(p[m]);
                        m++;
                    }
                    else if (valinta == 2)
                    {
                        Console.WriteLine("Kirjoita pelaajan numero: ");
                        int tmp = Int32.Parse(Console.ReadLine());
                        joukkue.PoistaaPelaaja(tmp);
                        Console.WriteLine(joukkue.ToString());
                    }
                    else if (valinta == 3)
                    {
                        Console.WriteLine(joukkue.ToString());
                    }
                }
            }
        }
    }
}