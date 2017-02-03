using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kirjoita vuosi:");
                string text = Console.ReadLine();
                if (text == "x" || text == "exit")
                    break;
                int date = Convert.ToInt32(text);
                if (date % 100 != 0 && date % 1000 != 0)
                {
                    if (date % 4 == 0)
                        Console.WriteLine("Vuosi on karkausvuosi");
                    else
                        Console.WriteLine("Vuosi ei ole karkausvuosi");
                }
                else if (date % 400 == 0)
                    Console.WriteLine("Vuosi on karkausvuosi");
                else
                    Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
    }
}
