using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Vehicle
    {
        //Properties
        public string Nimi { get; set; }
        int nopeus;
        public int Nopeus
        {
            get
            {
                return nopeus;
            }
            set
            {
                nopeus = value;
                if (nopeus < 0 || nopeus > 200)
                {
                    nopeus = 0;
                }
            }
        }
        int tyres;
        public int Tyres
        {
            get
            {
                return tyres;
            }
            set
            {
                tyres = value;
                if (tyres < 0 || tyres > 100)
                {
                    tyres = 0;
                }
            }
        }
        public void PrintData()
        {
            Console.WriteLine(Nimi);
            Console.WriteLine(Nopeus);
            Console.WriteLine(Tyres);
        }
        string text;
        public string Tostring(string Nimi, int Nopeus, int Tyres)
        {
            text = Nimi + " " + Nopeus + " " + Tyres;
            return text;
        }
    }
}
