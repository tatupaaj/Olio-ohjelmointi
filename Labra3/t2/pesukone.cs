using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesukone
{
    class Pesukone
    {
        // ominaisuudet
        public bool Onkopaalla { get; set; }
        int lampo;
        public int Lampotila
        {
            get
            {
                return lampo;
            }
            set
            {
                lampo = value;
                if (lampo < 30 || lampo > 90)
                {
                    lampo = 30;
                }
            }
        }
        int kieros;
        public int Kieros
        {
            get
            {
                return kieros;
            }
            set
            {
                kieros = value;
                if (kieros < 40 || kieros > 80)
                {
                    kieros = 40;
                }
            }
        }
        public string Tyyli { get; set; }

        public int Aika { get; set; }

    }
}