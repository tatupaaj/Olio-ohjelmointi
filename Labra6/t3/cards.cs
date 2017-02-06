using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    interface IKortit
    {
        string Nimi { get; set; }
        int Numero { get; set; }
        string ToString();
    }

    public class Hertta : IKortit
    {
        public string Nimi { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Numero + " " + Nimi + " #";
        }
    }
    public class Ruutu : IKortit
    {
        public string Nimi { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Numero + " " + Nimi + " #";
        }
    }
    public class Risti : IKortit
    {
        public string Nimi { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Numero + " " + Nimi + " #";
        }
    }
    public class Pata : IKortit
    {
        public string Nimi { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Numero + " " + Nimi + " #";
        }
    }
}