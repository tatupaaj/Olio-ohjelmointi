using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opiskelija;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            List();
        }
        static void List()
        {
            Opiskelija[] opiskelija = new Opiskelija[5];
            for (int i = 0; i < 5; i++)
            {
                opiskelija[i] = new Opiskelija();
            }

            opiskelija[0].Nimi = "Matias";
            opiskelija[0].Tunnus = "K2134";
            opiskelija[0].Ika = 22;
            opiskelija[0].Postti = "k2134@student.jamk.fi";



            opiskelija[1].Nimi = "Marika";
            opiskelija[1].Tunnus = "K2232";
            opiskelija[1].Ika = 27;
            opiskelija[1].Postti = "k2232@student.jamk.fi";

            opiskelija[2].Nimi = "Nea";
            opiskelija[2].Tunnus = "K2176";
            opiskelija[2].Ika = 20;
            opiskelija[2].Postti = "k2176@student.jamk.fi";

            opiskelija[3].Nimi = "Marko";
            opiskelija[3].Tunnus = "K2123";
            opiskelija[3].Ika = 25;
            opiskelija[3].Postti = "k2123@student.jamk.fi";

            opiskelija[4].Nimi = "Ville";
            opiskelija[4].Tunnus = "K2154";
            opiskelija[4].Ika = 26;
            opiskelija[4].Postti = "k2154@student.jamk.fi";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + " opiskeljian info: " + opiskelija[i].PrintData());
            }
        }
    }
}
