using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write your age:");
                string text = Console.ReadLine();
                if (text == "exit" || text == "x")
                    break;
                int age = Convert.ToInt32(text);
                if (age < 18)
                    Console.WriteLine("Olet alaikainen");
                else if (age > 17 && age < 65)
                    Console.WriteLine("Olet aikuinen");
                else
                    Console.WriteLine("Olet seniori");
            }
        }
    }
}