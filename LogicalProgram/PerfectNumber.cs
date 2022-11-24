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

            //variables
            int n = 28;
            int cube;
            int remainder;
            int result = 0;
            int temp = n;
            while (n != 0)
            {
                //reverse Calculation
                remainder = n % 10;
                cube = remainder * remainder * remainder;
                result = result + cube;
                n = n / 10;
            }
            n = temp;
            if(n == result)
            {
                Console.WriteLine("Is a Perfect Number");
            }
            {
                Console.WriteLine("Is not a Perfect Number");
            }
        }
    }
}