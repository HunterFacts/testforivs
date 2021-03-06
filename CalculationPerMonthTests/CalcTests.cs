﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationPerMonth;

namespace CalculationPerMonthTests
{
    [TestClass]
    public class CalcTests
    {
        /// <summary>
        /// Проверяет метод Calc.Calculation на правильность строки "Ваша цена за подписку составляет 4860,00руб. (Скидка 10%)"
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
            Assert.AreEqual(answer, "Ваша цена за подписку составляет 4860,00руб. (Скидка 10%)");
        }

        /// <summary>
        /// Проверяет метод Calc.Calculation на правильность строки "Ваша цена за подписку составляет 450,00руб. (Скидка 0%)"
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
            Assert.AreEqual(answer, "Ваша цена за подписку составляет 450,00руб. (Скидка 0%)");
        }

        /// <summary>
        /// Проверяет метод Calc.Calculation на правильность строки "Ваша цена за подписку составляет 1350,00руб. (Скидка 0%)"
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
            Assert.AreEqual(answer, "Ваша цена за подписку составляет 1350,00руб. (Скидка 0%)");
        }

        /// <summary>
        /// Проверяет метод Calc.Calculation на правильность строки "Ваша цена за подписку составляет 4702,50руб. (Скидка 5%)"
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
            Assert.AreEqual(answer, "Ваша цена за подписку составляет 4702,50руб. (Скидка 5%)");
        }

        /// <summary>
        /// Проверяет метод Calc.Calculation на правильность строки "Ваша цена за подписку составляет 2250,00руб. (Скидка 0%)"
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
            Assert.AreEqual(answer, "Ваша цена за подписку составляет 2250,00руб. (Скидка 0%)");
        }

    }
}
