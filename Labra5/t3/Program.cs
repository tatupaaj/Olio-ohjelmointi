using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nisakas;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen ihminen = new Ihminen { Nimi = "Matti", Ika = 35, Paino = 85, Pituus = 183 };
            Console.WriteLine(ihminen.ToString());
            ihminen.Liiku();
            ihminen.Kasva(ihminen);
            ihminen.Kasva(ihminen);
            Vauva vauva = new Vauva { Nimi = "Konsta", Ika = 1, Paino = 5, Pituus = 80 };
            Console.WriteLine(vauva.ToString());
            vauva.Liiku();
            vauva.Kasva(vauva);
            vauva.Kasva(vauva);
            Aikuinen aikuinen = new Aikuinen { Nimi = "Marika", Ika = 21, Paino = 60.6, Pituus = 170 };
            Console.WriteLine(aikuinen.ToString());
            aikuinen.Liiku();
            aikuinen.Kasva(aikuinen);
        }
    }
}
