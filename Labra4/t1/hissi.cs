using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hissi
{
    class Hissi
    {
        public int Kerros { set; get; }

        public string Tilanne(int Kerros)
        {
            if (Kerros < 1)
                return "There is no floor lower than 1!";
            else if (Kerros > 5)
                return "There is no floor higher than 5!";
            else return "Elevator is now in floor : " + Kerros;
        }
    }
}