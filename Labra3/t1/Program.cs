/* Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois,
 * sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
UML
Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.
Ohjelmointi
Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta. Säädä kiuas-oliota erilaisilla arvoilla,
jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta kiuas-olion käyttäminen jää näkyville. */
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
