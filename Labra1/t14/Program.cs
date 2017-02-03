using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l = { 0, 0, 0, 0, 0, 0 };
            while (true)
            {
                Console.WriteLine("Anna arvosana:");
                string text = Console.ReadLine();
                if (text == "exit" || text == "x")
                    break;
                else
                {
                    int tmp = Convert.ToInt32(text);
                    l[tmp]++;
                }
            }
            Console.WriteLine("\nArvosanat:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n" + i + ":");
                for (int j = 0; j < l[i]; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
