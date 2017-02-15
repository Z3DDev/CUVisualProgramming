using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

            Console.Write("Please enter a number: ");
            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);

            if (myInt < 0 || myInt == 0)
            {
                Console.WriteLine("Your number {0} is less than or equal to zero", myInt);
            }
            else if (myInt > 0 && myInt <= 10)
            {
                Console.WriteLine("Your number {0} is in range from 1 to 10", myInt);
            }
            else if (myInt > 10 && myInt <= 20)
            {
                Console.WriteLine("Your number {0} is in range from 11 to 20", myInt);
            }
            else if (myInt > 20 && myInt <= 30)
            {
                Console.WriteLine("Your number {0} is in range from 21 to 30", myInt);
            }
            else
            {
                Console.WriteLine("Your number {0} is greater than 30", myInt);
            }
        }
    }
}
