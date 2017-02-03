using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vahvistin
{
    class Vahvistin
    {
        int volume;
        bool onkoOikein;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {

                if (value < 0 || value > 100)
                    onkoOikein = false;
                else
                {
                    volume = value;
                    onkoOikein = true;
                }
            }
        }
        public bool Onkooikein()
        {
            return onkoOikein;
        }

        public string Tilanne(int Volume)
        {
            if (Onkooikein() == false)
                return "Wrong volume, it has to be 0-100";
            else
                return "Volume is " + Volume;
        }
    }
}
