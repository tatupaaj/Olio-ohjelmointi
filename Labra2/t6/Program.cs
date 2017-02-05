using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mikro;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaMikro();
        }

        static void TestaaMikro)
        {
            Mikro mikro = new Mikro();
            mikro.Onkopaalla = true;
            mikro.Aika = 5;
            mikro.Power = 200;
            Console.WriteLine("Mikro on päällä {0}", mikro.Onkopaalla);
            Console.WriteLine("Aika on {0}", mikro.Aika);
            Console.WriteLine("Voima on {0}", mikro.Power);
        }
    }
}