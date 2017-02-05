using Microsoft.VisualStudio.TestTools.UnitTesting;
using arraycalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycalc.Tests
{
    [TestClass()]
    public class ArrayCalcTests
    {
        [TestMethod()]
        public void SumTest()
        {
            ArrayCalc calc = new ArrayCalc();
            double[] n = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.60;

            // act
            double actual = calc.Sum(n);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AVGTest()
        {
            ArrayCalc calc = new ArrayCalc();
            double[] n = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.66;

            // act
            double actual = calc.AVG(n);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            ArrayCalc calc = new ArrayCalc();
            double[] n = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = -4.50;

            // act
            double actual = calc.Min(n);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            ArrayCalc calc = new ArrayCalc();
            double[] n = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 12.0;

            // act
            double actual = calc.Max(n);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}