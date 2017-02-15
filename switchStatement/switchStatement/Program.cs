using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;
            Console.WriteLine("Please enter a number between 1 and 3: ");
            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);

            switch(myInt)
            {
                case 1:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 2:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 3:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                default:
                    Console.WriteLine("Your number {0} is not between 1 and 3.", myInt);
                    break;
            }
        }
    }
}
