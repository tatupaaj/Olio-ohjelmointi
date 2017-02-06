using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vahvistin;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaVahvistin();
        }

        static void TestaaVahvistin()
        {
            Vahvistin vahvistin = new Vahvistin();
            while (true)
            {
                Console.WriteLine("Give a new volume value (0-100)");
                string text = Console.ReadLine();
                if (text == "x")
                    break;
                else
                {
                    vahvistin.Volume = Convert.ToInt32(text);
                    Console.WriteLine(vahvistin.Tilanne(vahvistin.Volume));
                }
            }
        }
    }
}
