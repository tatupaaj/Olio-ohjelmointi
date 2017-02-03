using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t1Kiuas; //kysy class
namespace t1
{

    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }

        // tehtävä kiuas-luokan testaus
        static void TestaaKiuas()
        {
            // luodaan kiuas olio
            Kiuas kiuas = new Kiuas();
            // pistetään kiuas lämpenemään ja asetetaan lämpö ja kosteutta
            kiuas.Onkopaalla = true;
            kiuas.Lampo = 90;
            kiuas.Kosteus = 50;
            Console.WriteLine("Kiuas on päällä {0}", kiuas.Onkopaalla);
            Console.WriteLine("Kiukaan lämptilä {0}", kiuas.Lampo);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            // tarkistaan mitä tapahtuu jos ei ole oikein määrä
            kiuas.Kosteus = 500;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }
    }
}