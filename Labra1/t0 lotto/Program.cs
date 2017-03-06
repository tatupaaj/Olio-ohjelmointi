using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita arpon numero:");
              int k = System.Convert.ToInt32(Console.ReadLine());
              Random rnd = new Random();
              for (int l = 0; l < k; l++)
              {
                  int[] luku = new int[7];
                  int[] winluku = { 13, 11, 9, 7, 5, 3, 1 };
                  luku[0] = rnd.Next(0, 40);
                  for (int i = 1; i < 7; i++)
                  {
                      luku[i] = rnd.Next(0, 40);
                      for (int j = 0; j < i; j++)
                      {
                          if (luku[i] == luku[j])
                              luku[i] = rnd.Next(0, 40);
                      }
                  }
                  for (int i = 0; i < 7; i++)
                  {
                      Console.Write(luku[i] + " ");
                  }
                  int n = 0;
                  for (int i = 0; i < 7; i++)
                  {
                      for (int j = 0; j < 7; j++)
                      {
                          if (luku[i] == winluku[j])
                              n++;
                      }
                  }
                  Console.Write("     Sait " + n + " voittonumeroa");
                  Console.WriteLine(" ");
        }

        }
    }
}