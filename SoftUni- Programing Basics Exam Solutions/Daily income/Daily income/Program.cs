using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_income
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyIncome = double.Parse(Console.ReadLine()),
                   dollarPrice = double.Parse(Console.ReadLine());

            double monthlyIncome = dailyIncome * workDays;
            double yearIncome = monthlyIncome * 12 + monthlyIncome * 2.5f;
            double clearIncome = (yearIncome - yearIncome * 0.25f)*dollarPrice;
            double averageDailyIncome = clearIncome / 365;

            Console.WriteLine("{0:F2}",averageDailyIncome);
        }
    }
}
