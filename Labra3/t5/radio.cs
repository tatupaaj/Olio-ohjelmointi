using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    class Radio
    {
        public bool Onkopaalla { get; set; }
        public int Voima { get; set; }

        public float Kanava { get; set; }

        public bool VoimaVaarin(int Voima)
        {
            if (Voima < 0 || Voima > 9)
                return false;
            else
                return true;
        }

        public bool KanavaVaarin(double Kanava)
        {
            if (Kanava < 2000.0 || Kanava > 26000.0)
                return false;
            else
                return true;
        }
    }
}