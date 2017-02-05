using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nisakas
{
    abstract class Nisakas
    {
        public int Ika { get; set; }

        public abstract void Liiku();
    }

    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Ihminen liikuu");
        }
        private int tmp = 0;
        public void Kasva(Nisakas nisakas)
        {
            int ika = nisakas.Ika;
            Console.WriteLine("Seurava vuona ihminen on {0} vanha", ika + 1 + tmp);
            tmp++;
        }

        public override string ToString()
        {
            return "Ihmisten nimi: " + Nimi + " Ika: " + Ika + " vuotta. Pituus: " + Pituus + " sm. Paino: " + Paino + " kg.";
        }
    }

    class Vauva : Ihminen
    {
        public override void Liiku()
        {
            Console.WriteLine("Vauva konttaa");
        }

        public override string ToString()
        {
            return "Vauvan nimi: " + Nimi + " Ika: " + Ika + " vuotta. Pituus: " + Pituus + " sm. Paino: " + Paino + " kg.";
        }
    }

    class Aikuinen : Ihminen
    {
        public override void Liiku()
        {
            Console.WriteLine("Aikuinen kävelee");
        }

        public override string ToString()
        {
            return "Aikusten nimi: " + Nimi + " Ika: " + Ika + " vuotta. Pituus: " + Pituus + " sm. Paino: " + Paino + " kg.";
        }
    }
}