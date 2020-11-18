using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class PartnersCashback
    {
        public void McDonalds(double cashback, double sumpokupok, double sum)
        {
            cashback = 0.2;
            Console.WriteLine("Введите сумму покупок из чека");
            sumpokupok = int.Parse(Console.ReadLine());
            sum += sumpokupok * cashback;

            Console.WriteLine($"На ваш счет было зачислено", sumpokupok * cashback, " Ваш баланс составляет", sum);
        }



        public void Amazon(double cashback, double sumpokupok, double sum)
        {
            cashback = 0.1;
            Console.WriteLine("Введите сумму покупок из чека");
            sumpokupok = int.Parse(Console.ReadLine());
            sum += sumpokupok * cashback;

            Console.WriteLine($"На ваш счет было зачислено", sumpokupok * cashback, " Ваш баланс составляет", sum);
        }


        public void Apple(double cashback, double sumpokupok, double sum)
        {
            cashback = 0.24;
            Console.WriteLine("Введите сумму покупок из чека");
            sumpokupok = int.Parse(Console.ReadLine());
            sum += sumpokupok * cashback;

            Console.WriteLine($"На ваш счет было зачислено", sumpokupok * cashback, " Ваш баланс составляет", sum);

        }
    }
}