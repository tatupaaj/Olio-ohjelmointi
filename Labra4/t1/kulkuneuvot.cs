using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulkuneuvot
{
    class Rengas
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string RengasKoko { get; set; }

        public override string ToString()
        {
            return "Merkki: " + Merkki + "Tyyppi: " + Tyyppi + "Rengaskoko: " + RengasKoko;
        }
    }
    class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;
        public List<Rengas> Renkaat { get; }
        public Auto()
        {
            Renkaat = new List<Rengas>();
        }
        public void LisaaRengas(Rengas rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisättuy {1}", rengas.Tyyppi, Merkki);
            }
            else
            {
                Console.WriteLine("No room for a new tyres, sorry!");
            }
        }
        public override string ToString()
        {
            string s = "Pirssissä: " + Merkki + " malli :" + Malli + "\nRenkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}