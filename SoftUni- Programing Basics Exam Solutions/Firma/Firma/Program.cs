using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = int.Parse(Console.ReadLine()),
                dayHad= int.Parse(Console.ReadLine()),
                employees= int.Parse(Console.ReadLine());

            double workHours = (dayHad - dayHad /10) * 8 + employees * 2 * dayHad;
            double diff = Math.Floor(workHours - hoursNeeded);

            if (diff < 0)
            {
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Abs(diff));
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.",diff);
            }
        }
    }
}
