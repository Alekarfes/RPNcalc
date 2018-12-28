using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatoRPN;

namespace TransCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRPN1()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("2+2-2/2");
            Assert.AreEqual(calc.RPN, "2 2 + 2 2 / -");
        }
        [TestMethod]
        public void TestRPN2()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("456+(9*2)+4");
            Assert.AreEqual(calc.RPN, "456 9 2 * + 4 +");
        }

        [TestMethod]
        public void TestRPN3()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("2 + 3 / 4");
            Assert.AreEqual(calc.RPN, "2 3 4 / +");
        }

        [TestMethod]
        public void TestResult1()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("700+(2-4/2+(6))*2");
            Assert.AreEqual(calc.Result, "712");
        }

        [TestMethod]
        public void TestResult2()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("414 / ( 55 - 27 / 3 )");
            Assert.AreEqual(calc.Result, "9");
        }

        [TestMethod]
        public void TestResult3()
        {
            RPNcalc calc = new RPNcalc();
            calc.Calculate("(3*7+2*8+1*9)/(20+27/9)");
            Assert.AreEqual(calc.Result, "2");
        }
    }
}
