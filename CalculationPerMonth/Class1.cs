using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPerMonth
{
    public class Calc
    {
        public string Calculation(int Price, string[] MonthsAbsence, string[] MonthsSubscription)
        {
            int check = 0;
            int discount = 0;
            int result = 0;
            foreach (string monthsub in MonthsSubscription)
            {
                foreach (string monthab in MonthsAbsence)
                {
                    check = 1;
                    if (monthsub == monthab)
                    {
                        check = 0;
                        discount--;
                        break;

                    }
                }
                if (check == 1)
                {
                    result = result + Price;
                }
                discount++;
            }
            if (discount >= 6 && discount < 12)
            {
                double res = Convert.ToDouble(result);
                res = res * 0.95;
                string answer = Convert.ToString(res);
                return ("Ваша цена за подписку представляет " + answer + "руб. (Скидка 5%)");
            }
            else if (discount >= 12)
            {
                double res = Convert.ToDouble(result);
                res = res * 0.90;
                string answer = Convert.ToString(res);
                return ("Ваша цена за подписку представляет " + answer + "руб. (Скидка 10%)");
            }
            else
            {
                string answer = Convert.ToString(result);
                return ("Ваша цена за подписку представляет " + answer + "руб. (Скидка 0%)");
            }
        }
    }
}
