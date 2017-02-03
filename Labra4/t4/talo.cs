using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talo
{
    class Talo
    {
        public string Osoite { get; set; }
        public string Materiaali { get; set; }
        public int Kerrokset { get; set; }
        public int HuoneenMaara { get; set; }
        private int tmp = 0;
        public List<Huone> Huoneet { get; }
        public string ToString()
        {
            return "Talon osoite on: " + Osoite + " tehty materiaalista: " + Materiaali + " Talossa on " + Kerrokset + " kerrosta ja " + HuoneenMaara + " huonetta";
        }
        public Talo()
        {
            Huoneet = new List<Huone>();
        }
        public void LisaaHuone(Huone huone)
        {
            if (tmp < HuoneenMaara)
            {
                tmp++;
                Huoneet.Add(huone);
                Console.WriteLine("Talossa on huone: {0} {1} kokoinen", huone.Nimi, huone.Koko);
            }
            else
                Console.WriteLine("Ei ole enää paikkaa");
        }
    }

    class Huone : Talo
    {
        public string Nimi { get; set; }
        public string Koko { get; set; }
    }

    interface IHenkilo
    {
        string Nimi { get; set; }
        string Tilanne();

    }

    class Perheenjasen : IHenkilo
    {
        public string Nimi { get; set; }
        public string Tilanne()
        {
            return "Olen kotona";
        }
    }

    class Vieras : IHenkilo
    {
        public string Nimi { get; set; }
        public string Tilanne()
        {
            return "Olen kylässä";
        }
    }
}
