using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= inpt; i++)
            {
                Console.Write(new string('-',inpt*3));
                Console.Write("*");
                Console.Write(new string('-',i-1));
                Console.Write("*");
                Console.WriteLine(new string('-', inpt*2-1-i));
            }

            for (int i = 1; i <= inpt/2; i++)
            {
                Console.Write(new string('*', inpt * 3+1));
                Console.Write(new string('-', inpt - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', inpt - 1));
            }

            for (int i = 0; i < inpt / 2; i++)
            {
                Console.Write(new string('-',3*inpt-i));
                Console.Write('*');
                if (i == inpt/2 - 1)
                    Console.Write(new string('*', inpt - 1 + 2 * i));
                else
                    Console.Write(new string('-',inpt-1+2*i));
                Console.Write('*');
                Console.WriteLine(new string('-', inpt-1-i));
            }
        }
    }
}
