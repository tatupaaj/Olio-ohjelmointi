using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita ensimmaisen taulukon koko: ");
            int n1 = Int32.Parse(Console.ReadLine());
            int[] l1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Anna luku:");
                l1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Kirjoita toisen taulukon koko: ");
            int n2 = Int32.Parse(Console.ReadLine());
            int[] l2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Anna luku:");
                l2[i] = Int32.Parse(Console.ReadLine());
            }
            int n = n1 + n2;
            int[] l = new int[n];
            for (int i = 0; i < n1; i++)
            {
                l[i] = l1[i];
            }
            int k = 0;
            for (int i = n1; i < n; i++)
            {
                l[i] = l2[k];
                k++;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (l[i] > l[j])
                    {
                        int tmp = l[i];
                        l[i] = l[j];
                        l[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(l[i] + " ");
            }
        }
    }
}