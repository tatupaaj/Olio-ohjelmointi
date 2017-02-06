using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using registeri;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri()
        {
            // ludaan muutamaan testi henkilö
            Henkilot popo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "311270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Kirsi", Sukunimi = "Kernell", Hetu = "121270-234B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Mat", Sukunimi = "Mickelson", Hetu = "011280-456C" };
            // lisätään henkilöt popoon
            popo.LisaaHenkilo(hlo);
            popo.LisaaHenkilo(hlo1);
            popo.LisaaHenkilo(hlo2);
            // tulostetaan popo näytölle
            foreach (Henkilo h in popo.Henkilolista)
            {
                Console.WriteLine("Henkilö {0}", h.ToString());
            }
            //TODO kysy käyttäjältä hetu sitä vataava henkilö näytölle
            Console.WriteLine("Löyty henkilö {0}", popo.HaeHenkiloHetulla("011280-456C"));
            // henkilö näytölle indexilla
            Console.WriteLine("Löyty henkilö {0}", popo.HaeHenkilo(1));
        }
    }
}
