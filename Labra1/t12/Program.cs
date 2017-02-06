using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kirjoita " + (i + 1) + " luku:");
                luku[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (luku[i] < luku[j])
                    {
                        int tmp = luku[i];
                        luku[i] = luku[j];
                        luku[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(luku[i] + " ");
            }
        }
    }
}