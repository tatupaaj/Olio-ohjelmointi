using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shape;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                    Console.WriteLine("Chose circle (press 0) or rectangle (press 1):");
                    string valinta = Console.ReadLine();
                    if (valinta == "0")
                    {
                        Console.WriteLine("Write radius of the circle:");
                        Circle circle = new Circle();
                        valinta = Console.ReadLine();
                        circle.Radius = double.Parse(valinta);
                        circle.Area();
                        circle.Circumference();
                    }
                    else if (valinta == "1")
                    {
                        Console.WriteLine("Write length of the rectangle:");
                        Rectangle rectangle = new Rectangle();
                        valinta = Console.ReadLine();
                        rectangle.Length = double.Parse(valinta);
                        Console.WriteLine("Write width of the rectangle:");
                        valinta = Console.ReadLine();
                        rectangle.Width = double.Parse(valinta);
                        rectangle.Area();
                        rectangle.Circumference();
                    }
                    else
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
