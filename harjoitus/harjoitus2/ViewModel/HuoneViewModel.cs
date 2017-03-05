using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using harjoitus2.Model;

namespace harjoitus2.ViewModel
{
    class HuoneViewModel
    {
        public Huone Huone1 { get; set; }
        public List<Esine> Esineet;
        public HuoneViewModel()
        {
            Huone1 = new Huone {Number = 1};
            List<Esine> esineet = new List<Esine>();
            Esine esine1 = new Esine { Name = "table" };
            Esine esine2 = new Esine { Name = "chair" };
            esineet.Add(esine1);
            esineet.Add(esine2);
            Esineet = esineet;
        }
    }
}
