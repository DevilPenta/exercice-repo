using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int rows = num / 100 + ((num / 10) % 10),
                colums = num / 100 + num % 10,
                currNum=num;

            for (int i = 0; i < rows; i++)
            {
                if (currNum % 5 == 0) currNum -= num / 100;
                else if (currNum % 3 == 0) currNum -= (num / 10) % 10;
                else currNum += num % 10;
                Console.Write(currNum);

                for (int p = 1; p < colums; p++)
                {
                    if (currNum % 5 == 0) currNum -= num / 100;
                    else if (currNum % 3 == 0) currNum -= (num / 10) % 10;
                    else currNum += num % 10;
                    Console.Write(" {0}", currNum);
                }

                Console.WriteLine();
            }

        }
    }
}
