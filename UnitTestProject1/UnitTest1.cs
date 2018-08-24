using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationPerMonth;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] {"September", "October","December", "November", "January", "August" };
            string[] monthper = new string[] { "February"};
            int Price = 300;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }
    }
}
