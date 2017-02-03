using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikro
{
    class Mikro
    {
        public bool Onkopaalla { get; set; }
        int aika;
        public int Aika
        {
            get
            {
                return aika;
            }
            set
            {
                aika = value;
                if (aika < 0 || aika > 120)
                {
                    aika = 1;
                }
            }
        }
        int power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
                if (power < 100 || power > 1000)
                {
                    power = 0;
                }
            }
        }
    }
}
