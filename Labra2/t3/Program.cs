using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using televisio;

namespace t3
{
    class program
    {
        static void Main(string[] args)
        {
            TestaaPesukone();
        }
        static void TestaaPesukone()
        {
            Televisio televisio = new Televisio();
            televisio.Onkopaalla = true;
            televisio.Kanava = 10;
            televisio.Volume = 15;
            Console.WriteLine("Televisio on päällä {0}", televisio.Onkopaalla);
            Console.WriteLine("Television kanava on {0}", televisio.Kanava);
            Console.WriteLine("Television äänenvoimakkuus {0}", televisio.Volume);
        }
    }
}