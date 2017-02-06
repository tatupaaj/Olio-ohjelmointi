using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kirjoita pistetta:");
                l[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (l[i] > l[j])
                    {
                        int tmp = l[i];
                        l[i] = l[j];
                        l[j] = tmp;
                    }
                }
            }
            int summa = 0;
            for (int i = 1; i < 4; i++)
            {
                summa = summa + l[i];
            }
            Console.WriteLine("Kokonaispisteet ovat " + summa);
        }
    }
}
