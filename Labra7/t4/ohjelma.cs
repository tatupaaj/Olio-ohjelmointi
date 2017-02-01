using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelma
{
    [Serializable]
    class Ohjelma
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public string Alkuaika { get; set; }
        public string Loppuaika { get; set; }
        public string Infoteksti { get; set; }
        public string ToString()
        {
            return "Ohjelman nimi: " + Nimi + "  kanava: " + Kanava + "  aika on " + Alkuaika + " - " + Loppuaika + "  info: " + Infoteksti;
        }
    }
}
