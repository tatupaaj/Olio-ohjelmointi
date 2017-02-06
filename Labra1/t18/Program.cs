using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita lause:");
            int m = 0;
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length / 2; i++)
                if (text[i] != text[text.Length - i - 1])
                {
                    Console.WriteLine("Ei ole palindromi");
                    m = 0;
                    break;
                }
                else
                    m = 1;
            if (m == 1)
                Console.WriteLine("On palindromi");
        }
    }
}
