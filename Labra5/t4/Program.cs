using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talo;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Talo talo = new Talo { Osoite = "Kelokatu 2", Materiaali = "puutalo", Kerrokset = 2, HuoneenMaara = 6 };
            Console.WriteLine(talo.ToString());
            Huone huone1 = new Huone { Nimi = "Keittiö", Koko = "5*6" };
            talo.LisaaHuone(huone1);
            Huone huone2 = new Huone { Nimi = "Makuhuone", Koko = "4*5" };
            talo.LisaaHuone(huone2);
            Huone huone3 = new Huone { Nimi = "Makuhuone", Koko = "4*5" };
            talo.LisaaHuone(huone3);
            Huone huone4 = new Huone { Nimi = "Olohuone", Koko = "5*6" };
            talo.LisaaHuone(huone4);
            Huone huone5 = new Huone { Nimi = "Vessa", Koko = "5*6" };
            talo.LisaaHuone(huone5);
            Huone huone6 = new Huone { Nimi = "Sauna", Koko = "3*3" };
            talo.LisaaHuone(huone6);
            Perheenjasen perheenjasen = new Perheenjasen { Nimi = "Matti" };
            Vieras vieras = new Vieras { Nimi = "Juuso" };
            Console.WriteLine("{0} tulee kotiin ja sanoo: {1}", perheenjasen.Nimi, perheenjasen.Tilanne());
            Console.WriteLine("{0} tulee kotiin ja sanoo: {1}", vieras.Nimi, vieras.Tilanne());
        }
    }
}
