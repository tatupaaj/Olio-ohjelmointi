using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus.Model
{
    public class Huone
    {
        public string Name { get; set; }
        //public int HuoneNumero { get; set; }
        public List<Esine> Esineet { get; set; }
        public int AvaidenMaara { get; set; }
    }

    public class Esine
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Esine(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }

    public class Avain
    {
        public int AvainNumero { get; set; }
        public bool OnkoLöyty { get; set; }
    }
}

