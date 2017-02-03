using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulkuneuvot
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosi { get; set; }
        public string Vari { get; set; }
    }

    class Polkupyora : Kulkuneuvo
    {
        public bool Vaihdepyora { get; set; }
        public string Mallinimi { get; set; }

        public Polkupyora()
        {

        }

        public Polkupyora(string nimi, string malli, int vuosi, string vari, bool vaihdepyora, string mallinini)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosi = vuosi;
            Vari = vari;
            Vaihdepyora = vaihdepyora;
            Mallinimi = mallinini;
        }

        public string Info()
        {
            return "Name: " + Nimi + " Model: " + Malli + " Year of model: " + Vuosi + " Color: " + Vari + " GearWheels: " + Vaihdepyora + " Gear name: " + Mallinimi;
        }
    }

    class Vene : Kulkuneuvo
    {
        public string Tyyppi { get; set; }
        public int Istuinpaikka { get; set; }

        public Vene()
        {

        }

        public Vene(string nimi, string malli, int vuosi, string vari, string tyyppi, int istuinpaikka)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosi = vuosi;
            Vari = vari;
            Tyyppi = tyyppi;
            Istuinpaikka = istuinpaikka;
        }

        public string Info()
        {
            return "Name: " + Nimi + " Model: " + Malli + " Year of model: " + Vuosi + " Color: " + Vari + " Type: " + Tyyppi + " Amount of seats: " + Istuinpaikka;
        }
    }
}
