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
            opettajanhuone = new Huone("Huone 1", "pack://application:,,,/Resources/1.png");
            esine1 = new Esine("table", "pack://application:,,,/Resources/table.png", false);
            //{Binding opettajanhuone.Image, Mode=OneWay}
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
