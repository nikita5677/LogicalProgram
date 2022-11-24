using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class ReverseNumber
    {
        public static void Reverse()
        {
            //variables
            int n;
            int remainder;
            int result = 0;
            Console.WriteLine("Enter  the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                //reverse Calculation
                remainder = n % 10;
                result = result * 10 + remainder;
                n = n / 10;
            }
            //print the reverse number
            Console.WriteLine("Reverse of Entered Number is : " + result);
            Console.ReadLine();
        }
    }
}