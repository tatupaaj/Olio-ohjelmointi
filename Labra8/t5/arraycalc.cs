using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycalc
{
    public class ArrayCalc
    {
        public double Sum(double[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum = sum + n[i];
            }
            return sum;
        }

        public double AVG(double[] n)
        {
            double avg = 0;
            for (int i = 0; i < n.Length; i++)
            {
                avg = avg + n[i];
            }
            avg = avg / n.Length;
            return avg;
        }

        public double Min(double[] n)
        {
            double min = 0;
            for (int i = 0; i < n.Length-1; i++)
            {
                if (n[i] < n[i + 1])
                    min = n[i];
            }
            return min;
        }

        public double Max(double[] n)
        {
            double max = 0;
            for (int i = 0; i < n.Length-1; i++)
            {
                if (n[i] < n[i + 1])
                    max = n[i+1];
            }
            return max;
        }
    }
}
