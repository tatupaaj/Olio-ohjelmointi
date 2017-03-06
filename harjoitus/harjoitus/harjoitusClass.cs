using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitusClass
{
    public class Huone
    {
        public int HuoneNumero { get; set; }
        public int AvaidenMaara { get; set; }
    }

    public class Esine
    {
        public int Numero { get; set; }
        public string Image { get; set; }
    }

    public class Avain
    {
        public int AvainNumero { get; set; }
        public bool OnkoLöyty { get; set; }
    }
}

///https://metanit.com/sharp/wpf/11.php
