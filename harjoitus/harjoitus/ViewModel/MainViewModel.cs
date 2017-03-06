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
            huone1 = new Huone { Name = "Room 1" };
        }
        public Huone huone1 { get; set; }
    }
}
