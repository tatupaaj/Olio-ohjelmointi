/* Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
 * Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, 
 * että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo. 
 * +tehtävä. Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many times you want to throw a dice");
                int numero = Int32.Parse(Console.ReadLine());
                Random rnd = new Random();
                float avg = 0;
                int tmp = 0;
                int[] n = { 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < numero; i++)
                {
                    tmp = rnd.Next(1, 6);
                    n[tmp - 1]++;
                    avg = avg + tmp;
                }
                Console.WriteLine("Dice is now thrown {0} times, average is {1}", numero, avg / numero);
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("{0} count is {1}", i + 1, n[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
