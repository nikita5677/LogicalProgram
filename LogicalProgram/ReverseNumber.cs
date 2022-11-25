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
            int number;
            int result = 0;
            int rem;
            Console.WriteLine("Enter  the  number : ");
            number = Convert.ToInt32(Console.ReadLine());
            while(number != 0)
            {
                //reverse Calculation
                rem = number % 10; //123 % 10 = 3
                result = result * 10 + rem; //0 
                number = number / 10;
            }
            //print the reverse number
            Console.WriteLine("Reverse of Entered Number is : " + result);
            Console.ReadLine();
        }
    }
}
