using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*https://msdn.microsoft.com/en-us/library/ms229006(v=vs.110).aspx */

namespace Employee
{
    class Henkilo
    {
        public string Nimi { get; set; }
        public string Ammatti { get; set; }
        public int Palkka { get; set; }
    }

    class Tyontekija : Henkilo
    {
        public Tyontekija()
        {

        }
        public Tyontekija(string nimi, string ammatti, int palkka)
        {
            Nimi = nimi;
            Ammatti = ammatti;
            Palkka = palkka;
        }
        public string Info()
        {
            return Nimi + " " + Ammatti + " " + Palkka;
        }
    }

    class Pomo : Henkilo
    {
        public string Auto { get; set; }
        public int Bonus { get; set; }
        public Pomo()
        {

        }
        public Pomo(string nimi, string ammatti, int palkka, string auto, int bonus)
        {
            Nimi = nimi;
            Ammatti = ammatti;
            Palkka = palkka;
            Auto = auto;
            Bonus = bonus;
        }
        public string Info()
        {
            return Nimi + " " + Ammatti + " " + Palkka + " " + Auto + " " + Bonus;
        }
    }
}
