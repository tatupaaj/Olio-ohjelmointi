using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kulkuneuvot;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCarWithFourWheelsV2();
        }

        static void TestCarWithFourWheelsV2()
        {
            // create tyre
            Rengas tyre1 = new Rengas { Merkki = "Nokia", Tyyppi = "Hakkapeliitta", RengasKoko = "205R16" };
            // create a car
            Auto auto = new Auto { Merkki = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", auto.Merkki, auto.Malli);
            auto.LisaaRengas(tyre1);
            auto.LisaaRengas(tyre1);
            auto.LisaaRengas(tyre1);
            auto.LisaaRengas(tyre1);
            Console.WriteLine(auto.ToString());
        }

    }
}
