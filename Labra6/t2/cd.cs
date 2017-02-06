using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd
{
    class CDlevy
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        private List<Kappale> kappaleet;
        public List<Kappale> Kappalelista { get { return kappaleet; } }
        public override string ToString()
        {
            return "CD nimi: " + Nimi + " Artisti: " + Artisti + "Kappaleet:";
        }
        public CDlevy()
        {
            kappaleet = new List<Kappale>();
        }
        public void LisaaKappale(Kappale k)
        {
            kappaleet.Add(k);
        }
        public Kappale HaeKappale(string nimi)
        {
            foreach (Kappale k in kappaleet)
            {
                if (k.Nimi == nimi)
                    return k;
            }
            return null;
        }

    }
    class Kappale
    {
        public string Nimi { get; set; }
        public string Pituus { get; set; }
        public override string ToString()
        {
            return Nimi + " " + Pituus;
        }
    }
}