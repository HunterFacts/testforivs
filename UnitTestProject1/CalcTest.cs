using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationPerMonth;

namespace CalculationPerMonthTest
{
    [TestClass]
    public class CalcTest
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void AllMonthsTest()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September", "October", "November", "December", "January", "February", "March", "April", "May", "June", "July", "August" };
            string[] monthper = new string[] { "" };
            int Price = 450;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void OneMonthTest()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September" };
            string[] monthper = new string[] { "" };
            int Price = 450;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ThreeMonthTest()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September", "October", "December" };
            string[] monthper = new string[] { "" };
            int Price = 450;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void OneMonthAbuseTest()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September", "October", "November", "December", "January", "February", "March", "April", "May", "June", "July", "August" };
            string[] monthper = new string[] { "March" };
            int Price = 450;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ThreeMonthAbuseTest()
        {
            //September, October, November, December, January, February, March, April, May, June, July, August
            string[] monthsub = new string[] { "September", "October", "November", "December", "January", "February", "March", "April" };
            string[] monthper = new string[] { "February", "October", "November" };
            int Price = 450;
            Calc use = new Calc();
            string answer = use.Calculation(Price, monthper, monthsub);
            Console.WriteLine(answer);
        }

    }
}
