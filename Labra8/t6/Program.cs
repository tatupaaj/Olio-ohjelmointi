using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavara;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.Asiakas = "Juuso Laulainen";
            Tavara t1 = new Tavara {Nimi = "Milk", Hinta = 1.75, Maara = 1 };
            Tavara t2 = new Tavara { Nimi = "Beer", Hinta = 5.24, Maara = 1 };
            Tavara t3 = new Tavara { Nimi = "Butter", Hinta = 2.50, Maara = 2 };
            invoice.LisaaTavara(t1);
            invoice.LisaaTavara(t2);
            invoice.LisaaTavara(t3);
            invoice.PrintInvoice();
        }
    }
}
