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
            while (true)
            {
                Console.WriteLine("Write number 1,2 or 3:");
                string text = Console.ReadLine();
                if (text == "exit" || text == "x")
                {
                    break;
                }
                if (text == "1")
                {
                    Console.WriteLine("yksi");
                }
                else if (text == "2")
                {
                    Console.WriteLine("kaksi");
                }
                else if (text == "3")
                {
                    Console.WriteLine("kolme");
                }
                else
                {
                    Console.WriteLine("joku muu luku");
                }
            }
        }
    }
}
