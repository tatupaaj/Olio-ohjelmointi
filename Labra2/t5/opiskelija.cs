using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opiskelija
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public int Ika { get; set; }
        public string Postti { get; set; }
        public string PrintData()
        {
            string text = Nimi + " " + Tunnus + " " + Ika + " " + Postti;
            return text;
        }
    }

}
