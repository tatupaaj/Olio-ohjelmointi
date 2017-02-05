using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Area();
        public abstract void Circumference();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override void Area()
        {
            double area = 3.14 * Radius * Radius;
            Console.WriteLine("Area={0}", area);
        }
        public override void Circumference()
        {
            double circumference = 2 * 3.14 * Radius;
            Console.WriteLine("Circumference={0}", circumference);
        }

    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override void Area()
        {
            double area = Length * Width;
            Console.WriteLine("Area={0}", area);
        }
        public override void Circumference()
        {
            double circumference = 2 * Length + 2 * Width;
            Console.WriteLine("Circumference={0}", circumference);
        }
    }
}
