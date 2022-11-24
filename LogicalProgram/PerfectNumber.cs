using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class PerfectNumber
    {
        public static void Perfect()
        {
            int n, i, sum;
            Console.WriteLine("Enter  the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.WriteLine("This number is perfect.");
            else
                Console.WriteLine("This number is not a perfect.");
            Console.ReadLine();
        }
    }
}