using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tavara
{
    public class Tavara
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int Maara { get; set; }
        public double Total()
        {
            return Hinta * Maara;
        }
        public override string ToString()
        {
            return Nimi + " " + Hinta + "e " + Maara + " pieces " + Total() + "e total";
        }
    }

    public class Invoice
    {
        public string Asiakas { get; set; }
        private List<Tavara> tavarat;
        public List<Tavara> TavaraLista
        {
            get { return tavarat; }
        }
        public Invoice()
        {
            tavarat = new List<Tavara>();
        }
        public void LisaaTavara(Tavara t)
        {
            tavarat.Add(t);
        }
        public double ITotatal()
        {
            double total = 0;
            foreach (Tavara t in tavarat)
            {
                total = total + t.Total();
            }
            return Math.Round(total);
        }
        public void PrintInvoice()
        {
             Console.WriteLine("Customer {0}'s invoice:",Asiakas);
            foreach (Tavara t in tavarat)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("Total : {0}",ITotatal());
        }
    }
}
