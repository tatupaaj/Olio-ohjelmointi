using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jaakaappi;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jaakaappi jaakaappi = new Jaakaappi { Nimi = "Bosh", Vari = "valkoinen" };
            Console.WriteLine("Luotu uusi {0} jääkaappi  {1}", jaakaappi.Vari, jaakaappi.Nimi);
            Tuote tuote1 = new Tuote { Nimi = "Kurkku", Tyyppi = "Vihanekset", Maara = 2 };
            jaakaappi.LisaaTuote(tuote1);
            Tuote tuote2 = new Tuote { Nimi = "Kana", Tyyppi = "Liha", Maara = 1 };
            jaakaappi.LisaaTuote(tuote2);
            Tuote tuote3 = new Tuote { Nimi = "Kala", Tyyppi = "Liha", Maara = 1 };
            jaakaappi.LisaaTuote(tuote3);
            Tuote tuote4 = new Tuote { Nimi = "Kalja", Tyyppi = "Alkoholi", Maara = 10 };
            jaakaappi.LisaaTuote(tuote4);
            Console.WriteLine(jaakaappi.ToString());
        }
    }
}
