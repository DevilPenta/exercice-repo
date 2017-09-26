using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int treatedPatients = 0, untreatedPatients = 0,
                currTreatedPatients = 0, currUntreatedPatients = 0,
                incomingPatients,
                doctors=7;

            int days = int.Parse(Console.ReadLine());

            for (int i = 1; i <= days; i++)
            {
                //Console.WriteLine("Trea:{0}, un:{1}",treatedPatients, untreatedPatients);
                if (untreatedPatients > treatedPatients&&i%3==0) doctors++;
                incomingPatients = int.Parse(Console.ReadLine());

                currTreatedPatients = incomingPatients - doctors;
                if (currTreatedPatients <= 0)
                {
                    currTreatedPatients = incomingPatients;
                }
                else currTreatedPatients = doctors;

                currUntreatedPatients = incomingPatients - doctors;

                if (currUntreatedPatients < 0) currUntreatedPatients = 0;

                treatedPatients += currTreatedPatients;
                untreatedPatients += currUntreatedPatients;

            }

            Console.WriteLine("Treated patients: {0}.",treatedPatients);
            Console.WriteLine("Untreated patients: {0}.",untreatedPatients);
        }
    }
}
