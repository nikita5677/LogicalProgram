using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class PrimeNumber
    {
        public static void Prime()
        {
            // declare variable
            int i, n, m = 0, flag = 0;

            //take input
            Console.Write("Enter the number = ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                //check if n is prime or  not
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(n + " is a Prime Number");

            // wait for user to press any key
            Console.ReadKey();
        }
    }
}
