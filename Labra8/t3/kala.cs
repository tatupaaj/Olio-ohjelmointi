using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kala
{
    class Kala
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public string PaikanNimi { get; set; }
        public string Paikka { get; set; }
        public override string ToString()
        {
            return "-specie: " + Laji + " " + Pituus + " cm " + Paino + " kg " + "\n-place: " + PaikanNimi + "\n-location: " + Paikka;
        }
    }

    class Kalastaja
    {
        public string Nimi { get; set; }
        public string Numero { get; set; }
        private List<Kala> kalat;
        public List<Kala> kalalist
        {
            get { return kalat; }
        }
        public Kalastaja()
        {
            kalat = new List<Kala>();
        }
        public void LisaaKala(Kala kala)
        {
            kalat.Add(kala);
            Console.WriteLine("Fisher : {0} got a new fish \n{1}", Nimi, kala.ToString());
        }
        public void ListKala()
        {
            Console.WriteLine("Fisherman {0} has got following fishes:", Nimi);
            Console.WriteLine();
            foreach (Kala kala in kalat)
            { 
                Console.WriteLine(kala.ToString());
                Console.WriteLine();
            }
        }
        public void SortKala()
        {
            Kala[] kala = new Kala[kalat.Count];
            int n = 0;
            foreach (Kala k in kalat)
            {
                kala[n] = k;
                n++;
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (kala[i].Paino< kala[j].Paino)
                    {
                        Kala tmp = kala[i];
                        kala[i] = kala[j];
                        kala[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Sorted register:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(kala[i].ToString());
                Console.WriteLine();
            }
        }
    }

    class Kalastajat
    {
        public List<Kalastaja> Kalastajalista { get; }
        public Kalastajat()
        {
            Kalastajalista = new List<Kalastaja>();
        }
        public void LisaaKalastaja(Kalastaja k)
        {
            Kalastajalista.Add(k);
            Console.WriteLine("A new fisherman added to register:\n-" + k.Nimi);
        }
    }
}
