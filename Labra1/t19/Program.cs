using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t19
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana = "kahvikerma";
            char[] msana = new char[sana.Length];
            for (int i = 0; i < sana.Length; i++)
            {
                msana[i] = sana[i];
            }
            char[] asana = new char[sana.Length];
            char[] vsana = new char[5];
            for (int i = 0; i < sana.Length; i++)
            {
                asana[i] = '_';
            }
            int l = 0;
            int t = 0;
            Console.WriteLine("***Hirsipuu-peli***");
            Console.WriteLine(" ");
            while (true)
            {
                Console.WriteLine("Kirjoita kirjain:");
                char k = Convert.ToChar(Console.ReadLine());
                if (l == 5)
                {
                    Console.WriteLine("Valitettavasti havisit");
                    break;
                }
                if (msana.Contains(k))
                    for (int i = 0; i < sana.Length; i++)
                    {
                        if (k == sana[i])
                        {
                            asana[i] = k;
                            t++;
                        }
                    }
                else
                {
                    Console.WriteLine("ei ole tätä kirjainta");
                    vsana[l] = k;
                    l++;
                }
                for (int j = 0; j < sana.Length; j++)
                {
                    Console.Write(asana[j] + " ");
                }
                Console.WriteLine(" ");
                if (l != 0)
                {
                    Console.WriteLine("Arvatut ei kaytetyt kirjaimet:");
                    for (int i = 0; i < l; i++)
                    {
                        Console.Write(vsana[i] + " ");
                    }
                    Console.WriteLine(" ");
                }
                if (t == sana.Length)
                {
                    Console.WriteLine("Voitit!");
                    break;
                }
            }
        }
    }
}
