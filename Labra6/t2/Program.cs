using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cd;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaCD();
        }

        static void TestaaCD()
        {
            CDlevy cd = new CDlevy { Nimi = "Endless Forms Most Beautiful", Artisti = "Nightwish" };
            Kappale k1 = new Kappale { Nimi = "Shudder Before the Beautiful", Pituus = "6:29" };
            Kappale k2 = new Kappale { Nimi = "Weak Fantasy", Pituus = "5:23" };
            Kappale k3 = new Kappale { Nimi = "Elan", Pituus = "4:45" };
            Kappale k4 = new Kappale { Nimi = "Yours Is an Empty Hope", Pituus = "5:34" };
            Kappale k5 = new Kappale { Nimi = "Our Decades in the Sun", Pituus = "6:37" };
            Kappale k6 = new Kappale { Nimi = "My Walden", Pituus = "4:38" };
            Kappale k7 = new Kappale { Nimi = "Endless Forms Most Beautiful", Pituus = "4:45" };
            Kappale k8 = new Kappale { Nimi = "Edema Ruh", Pituus = "5:07" };
            Kappale k9 = new Kappale { Nimi = "Alpenglow", Pituus = "5:15" };
            Kappale k10 = new Kappale { Nimi = "The Eyes of Sharbat Gula", Pituus = "6:03" };
            Kappale k11 = new Kappale { Nimi = "The Greatest Show on Earth", Pituus = "24:00" };
            cd.LisaaKappale(k1);
            cd.LisaaKappale(k2);
            cd.LisaaKappale(k3);
            cd.LisaaKappale(k4);
            cd.LisaaKappale(k5);
            cd.LisaaKappale(k6);
            cd.LisaaKappale(k7);
            cd.LisaaKappale(k8);
            cd.LisaaKappale(k9);
            cd.LisaaKappale(k10);
            cd.LisaaKappale(k11);
            Console.WriteLine(cd.ToString());
            foreach (Kappale k in cd.Kappalelista)
            {
                Console.WriteLine(k.ToString());
            }
            Console.WriteLine("Anna kappaleen nimi: ");
            string tmp = Console.ReadLine();
            Console.WriteLine("Löyty kappale: " + cd.HaeKappale(tmp));
        }
    }
}
