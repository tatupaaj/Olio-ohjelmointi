using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registeri
{
    // this class cotains person properties
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; } //henkilötunnus
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Hetu;
        }
    }

    // this class holds person information in a collection
    class Henkilot
    {
        private List<Henkilo> henkilot;
        public List<Henkilo> Henkilolista
        {
            get { return henkilot; }
        }
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }
        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
                return henkilot.ElementAt(index);
            else
                return null;
        }
        public Henkilo HaeHenkiloHetulla(string hetu)
        {
            foreach (Henkilo hlo in henkilot)
            {
                if (hlo.Hetu == hetu)
                    return hlo;
            }
            return null;
        }
    }
}
