using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1Kiuas
{
    public class Kiuas
    {
        //Properties
        public bool Onkopaalla { get; set; }
        public float Lampo { get; set; }
        // kosteus voi olla 0-100
        float kosteus;
        public float Kosteus
        {
            get
            {
                return kosteus;
            }
            set
            {
                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }
        }
    }
}
