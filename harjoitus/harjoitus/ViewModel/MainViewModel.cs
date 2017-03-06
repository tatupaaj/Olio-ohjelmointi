using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using harjoitus.Model;

namespace harjoitus.ViewModel
{
    class MainViewModel
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            opettajanhuone = new Huone { Name = "Room 1" };
            esine1 = new Esine("table","pictures/table.png");
            //huone1.Esineet.Add(esine1);
            
        }
        public Huone opettajanhuone { get; set; }
        public Huone luokka { get; set; }
        public Huone ruokailu { get; set; }
        public Huone baari { get; set; }
        public Huone koti { get; set; }
        public Esine esine1 { get; set; }
    }
}
