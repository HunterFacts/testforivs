using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPerMonth
{
    public class Calc
    {
        /// <summary>
        /// Возвращает цену за подписку с учетом скидки.
        /// </summary>
        /// <param name="price">Цена за подписку на 1 месяц.</param>
        /// <param name="monthsAbsence">Месяцы исключение.</param>
        /// <param name="monthssubscription">Месяцы подписки, выбранные пользователем.</param>
        /// <returns>
        /// Метод Returned, который возвращает: 
        /// Строку формата "Ваша цена за подписку составляет {цена за подписку}руб. (Скидка {значение скидки}%)"
        /// </returns>
        public string Calculation(int price, string[] monthsabsence, string[] monthssubscription)
        {
            bool check = false;
            int discount = 0;
            int result = 0;
            foreach (string monthsub in monthssubscription)
            {
                check = !monthsabsence.Contains(monthsub);
                if (check)
                {
                    result = result + price;
                    discount++;
                }               
            }
            return Returned(discount, result);
           
        }
        /// <summary>
        /// Возвращает цену за подписку с учетом скидки.
        /// </summary>
        /// <param name="discount">Количество месяцев для учета скидки</param>
        /// <param name="result">Сумма оплаты без учёта скидки</param>
        /// <returns>Строка формата "Ваша цена за подписку составляет {цена за подписку}руб. (Скидка {значение скидки}%)"</returns>
        public string Returned (int discount, int result)
        {
            double res = result;
            string dis = "0";
            if (discount >= 12)
            {
                res = res * 0.90;
                dis = "10";
            }
            else if (discount >= 6){
                res = res * 0.95;
                dis = "5";
            }
            string answer = res.ToString("0.00");
            return $"Ваша цена за подписку составляет {answer}руб. (Скидка {dis}%)";
        }
    }
}
