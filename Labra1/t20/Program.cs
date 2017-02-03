using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t20
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vokaalit = { 'a', 'o', 'ä', 'ö', 'y', 'u', 'e', 'å', 'i', 'A', 'O', 'Y', 'U', 'Ä', 'Ö', 'I', 'E', 'Å' };
            int v = 0;
            int k = 0;
            Console.WriteLine("Kirjoita lause:");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (vokaalit.Contains(text[i]))
                    v++;
                else
                    k++;
            }
            Console.WriteLine("Lausessa on " + v + " vokaali kirjainta");
            Console.WriteLine("Lausessa on " + k + " konsonantti kirjainta");
        }
    }
}
