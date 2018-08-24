using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationPerMonth;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September", "October", "November", "December", "January", "February", "March", "April", "May", "June", "July", "August" };
            string[] monthper = new string[] { ""};
            int Price = 900;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }
    }
}
