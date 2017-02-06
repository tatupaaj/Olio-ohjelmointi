using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace televisio
{
    class Televisio
    {
        public bool Onkopaalla { get; set; }
        int kanava;
        public int Kanava
        {
            get
            {
                return kanava;
            }
            set
            {
                kanava = value;
                if (kanava < 1 || kanava > 100)
                {
                    kanava = 1;
                }
            }
        }
        int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                if (volume < 0 || volume > 20)
                {
                    volume = 0;
                }
            }
        }
    }
}
