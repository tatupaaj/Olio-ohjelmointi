using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tauluko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < 9; i++)
            {
                if (tauluko[i] % 2 == 0)
                    Console.WriteLine(tauluko[i] + " HEP");
                else
                    Console.WriteLine(tauluko[i]);
            }
        }
    }
}
