using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuote;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Tuote> tuotteet = new List<Tuote>();
                while (true)
                {
                    Console.WriteLine("Add product (Write 'x' if you want to exit):");
                    string nimi = Console.ReadLine();
                    if (nimi == "x")
                        break;
                    else
                    {

                        Console.WriteLine("Add product's prise:");
                        double hinta = Double.Parse(Console.ReadLine());
                        tuotteet.Add(new Tuote { Nimi = nimi, Hinta = hinta });
                    }
                }
                Console.WriteLine("All products in collection:");
                foreach (Tuote t in tuotteet)
                {
                    Console.WriteLine("- product: {0} {1} e", t.Nimi, t.Hinta);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
