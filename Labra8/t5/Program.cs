using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arraycalc;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCalc calc = new ArrayCalc();
            double[] n = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine(calc.Sum(n));
            Console.WriteLine(calc.AVG(n));
            Console.WriteLine(calc.Max(n));
            Console.WriteLine(calc.Min(n));
        }
    }
}
