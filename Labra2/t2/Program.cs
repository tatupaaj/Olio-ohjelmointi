using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pesukone;

namespace t1
{
    class program
    {
        static void Main(string[] args)
        {
            TestaaPesukone();
        }

        // tehtävä kiuas-luokan testaus
        static void TestaaPesukone()
        {
            Pesukone pesukone = new Pesukone();
            pesukone.Onkopaalla = true;
            pesukone.Lampotila = 60;
            pesukone.Kieros = 40;
            pesukone.Tyyli = "Valkoinenvain";
            pesukone.Aika = 60;
            Console.WriteLine("Pesukone on päällä {0}", pesukone.Onkopaalla);
            Console.WriteLine("Pesun lämpötilä {0}", pesukone.Lampotila);
            Console.WriteLine("Pesun tyyli {0}", pesukone.Tyyli);
            Console.WriteLine("Pesun aika {0}", pesukone.Aika);
        }
    }
}
