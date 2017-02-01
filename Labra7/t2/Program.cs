using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string curFile = @"d:\Temp\nimet.txt";
                if (File.Exists(curFile))
                {
                    string[] lines = System.IO.File.ReadAllLines(@"d:\Temp\nimet.txt");
                    string[] nimi = new string[lines.Length];
                    int[] maara = new int[lines.Length];
                    int t = 0;
                    foreach (string line in lines)
                    {
                        nimi[t] = line;
                        maara[t] = 1;
                        t++;
                    }
                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (nimi[i] == nimi[j])
                            {
                                maara[i]++;
                                nimi[j] = " ";
                            }
                        }
                    }
                    t = 0;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (nimi[i] != " ")
                            t++;
                    }
                    Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä sortattuna:", lines.Length, t);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (nimi[i] != " ")
                            Console.WriteLine("Nimi {0} esiintyy {1} kertaa", nimi[i], maara[i]);
                    }
                }
                else
                    Console.WriteLine("No such file!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
