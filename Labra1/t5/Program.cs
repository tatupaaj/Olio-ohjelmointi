using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write time in seconds:");
                string text = Console.ReadLine();
                if (text == "exit" || text == "x")
                    break;
                int time = Convert.ToInt32(text);
                double tmp = time / 3600;
                int x = (int)(tmp);
                time = time - x * 3600;
                tmp = time / 60;
                int y = (int)(tmp);
                int z = time - y * 60;
                Console.WriteLine(x + " tuntea " + y + " minuttia " + z + " sekunttia ");
            }
        }
    }
}
