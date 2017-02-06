/* Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja. Ohjelman pitää pystyä käsittelemään: 
 * saadun kalan perustiedot (laji, pituus ja paino), kalastajan perustiedot (nimi, puhelinnumero) 
 * sekä saadun kalapaikan perustiedot (nimi ja paikka). Pohdi tarvittava luokkarakenne UML-kaaviona. 
 * Toteuta pääohjelmassa kalastaja ja muutamia kaloja. Tulosta lopuksi kalarekisterin sisältö.
 * +tehtävä: tulosta kalarekisteri siten, että kalat ovat suuruusjärjestykessä (painavin ensin).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kala;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalastajat kalastajat = new Kalastajat();
            Kalastaja kalastaja = new Kalastaja { Nimi = "Kirsi Kernel", Numero = "020-12345678" };
            kalastajat.LisaaKalastaja(kalastaja);
            Kala kala1 = new Kala {Laji = "pike", Pituus = 120, Paino = 4.5, PaikanNimi = "The Lake of Jyväskylä", Paikka= "Jyväskylä" };
            Kala kala2 = new Kala { Laji = "salmon", Pituus = 190, Paino = 13.2, PaikanNimi = "River Teno", Paikka = "The Northern edge of Finland" };
            Console.WriteLine();
            kalastaja.LisaaKala(kala1);
            Console.WriteLine();
            kalastaja.LisaaKala(kala2);
            Console.WriteLine();
            kalastaja.ListKala();
            kalastaja.SortKala();
        }
    }
}
