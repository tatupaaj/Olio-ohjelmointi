using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaakaappi
{
    class Jaakaappi
    {
        public string Nimi { get; set; }
        public string Vari { get; set; }
        private const int maara = 10;

        private int lkmTuotteet = 0;
        public List<Tuote> Tuotteet { get; }
        public Jaakaappi()
        {
            Tuotteet = new List<Tuote>();
        }
        public void LisaaTuote(Tuote tuote)
        {
            if (lkmTuotteet < maara)
            {
                Tuotteet.Add(tuote);
                lkmTuotteet++;
                Console.WriteLine("Tuote {0} lisätty jääkaappiin", tuote.Nimi);
            }
            else
            {
                Console.WriteLine("Ei ole paikka enää!");
            }
        }
        public override string ToString()
        {
            string s = "Jääkaapissä: " + Nimi + " väri: " + Vari + "\nTuotteet:";
            foreach (Tuote r in Tuotteet)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
    class Tuote
    {
        public string Nimi { get; set; }
        public string Tyyppi { get; set; }
        public int Maara { get; set; }

        public override string ToString()
        {
            return "Tuoten nimi: " + Nimi + " Tyyppi: " + Tyyppi + " Kappaleita: " + Maara;
        }
    }
}