using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class FibbonnaciSeries
    {
        public static void Fibonnaci()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
            Console.ReadKey();
        }
    }
}
