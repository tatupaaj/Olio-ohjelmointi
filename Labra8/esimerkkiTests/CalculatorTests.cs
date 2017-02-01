using Microsoft.VisualStudio.TestTools.UnitTesting;
using esimerkki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimerkki.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            /// AAA periaate
            /// A = Arrange, tietojen alustus
            /// A = Act, kutsutaan metodia
            /// A = Assert, varmistetaan että tulos ok

            // Arrange 
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;

            // act
            int actual = calc.Add(a, b);

            //assert
            Assert.AreEqual(expected, actual);
            // ja toinen testi add-metodilla
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            int a = 2;
            int b = 1;
            int expected = 1;

            // act
            int actual = calc.Subtract(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;

            // act
            int actual = calc.Multiply(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            int a = 6;
            int b = 3;
            int expected = 2;

            // act
            int actual = calc.Divide(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}