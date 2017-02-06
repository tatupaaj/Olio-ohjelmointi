using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joukkue
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
        public string Rooli { get; set; }
        public override string ToString()
        {
            return Etunimi + Sukunimi + Ika + Numero + Rooli;
        }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private List<Pelaaja> pelaajat;
        public List<Pelaaja> Pelaajalista
        {
            get { return pelaajat; }
        }
        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();
        }
        public override string ToString()
        {
            string s = "Joukkuessa: " + Nimi + " kaupungista: " + Kotikaupunki + "\nPelaajat:";
            foreach (Pelaaja p in pelaajat)
            {
                if (p != null) s += "\n" + p.ToString();
            }
            return s;
        }
        private int jnumero = 0;
        private int maalinumero = 0;
        private int puolistajatnumero = 0;
        private int hyokkajatnumero = 0;
        public void LisaaPelaaja(Pelaaja p)
        {
            if (jnumero < 6)
            {
                if (p.Rooli == "maalivahti")
                {
                    if (maalinumero < 1)
                    {
                        pelaajat.Add(p);
                        maalinumero++;
                        jnumero++;
                        Console.WriteLine("Lisätty pelaaja: nimellä {0} {1} roolilla {2} ", p.Etunimi, p.Sukunimi, p.Rooli);
                    }
                    else
                        Console.WriteLine("On jo maalivahti joukkuessa!");
                }
                else if (p.Rooli == "puolustaja")
                {
                    if (puolistajatnumero < 2)
                    {
                        pelaajat.Add(p);
                        puolistajatnumero++;
                        jnumero++;
                        Console.WriteLine("Lisätty pelaaja: nimellä {0} {1} roolilla {2} ", p.Etunimi, p.Sukunimi, p.Rooli);
                    }
                    else
                        Console.WriteLine("On jo 2 puolistajaa joukkuessa!");
                }
                else if (p.Rooli == "hyökkäjä")
                {
                    if (hyokkajatnumero < 3)
                    {
                        pelaajat.Add(p);
                        hyokkajatnumero++;
                        jnumero++;
                        Console.WriteLine("Lisätty pelaaja: nimellä {0} {1} roolilla {2} ", p.Etunimi, p.Sukunimi, p.Rooli);
                    }
                    else
                        Console.WriteLine("On jo 3 hyökkäjää joukkuessa!");
                }
                else
                    Console.WriteLine("Väärin rooli!");
            }
            else
                Console.WriteLine("On jo täynä joukkue!");
        }
        public void PoistaaPelaaja(int n)
        {
            foreach (Pelaaja p in pelaajat)
            {
                if (p.Numero == n)
                {
                    pelaajat.Remove(p);
                }
            }
        }
    }
}
