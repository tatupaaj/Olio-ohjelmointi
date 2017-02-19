using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyo
{
    public class Henkilo
    {
        public string Sotu { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public DateTime SyntymaAika { get; set; }
        public int Ika { get; set; }
        public string Kokonimi()
        {
            return Etunimi + " " + Sukunimi;
        }
    }
    public class Tyontekija : Henkilo
    {
        public string Nimike { get; set; }
        public int Numero { get; set; }
        public DateTime AloitusPvm { get; set; }
        public float Palkka { get; set; }
        public string ToString()
        {
            return Numero + "=" + Kokonimi();
        }
        public float LaskePalkka()
        {
            return Palkka;
        }
    }
    public class Vakituinen : Tyontekija
    {
        public float KuukausiPalkka { get; set; }
        public float LaskePalkka()
        {
            return Palkka;
        }
    }
    public class OsaAikaien : Tyontekija
    {
        public float TunttiPalkka { get; set; }
        public int TehtytTunnit { get; set; }
        public float LaskePalkka()
        {
            return Palkka;
        }
    }
}
