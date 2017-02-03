using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hissi;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHissi();
        }

        static void TestaaHissi()
        {
            Hissi hissi = new Hissi();
            Console.WriteLine("Elevator is now in floor : 1 (Write x if you want to exit)");
            string retval = "";
            while (true)
            {
                Console.WriteLine("Give a floor number:");
                retval = Console.ReadLine();
                if (retval == "x")
                    break;
                else
                {
                    hissi.Kerros = Convert.ToInt32(retval);
                    Console.WriteLine(hissi.Tilanne(hissi.Kerros));
                }
            }
        }
    }
}