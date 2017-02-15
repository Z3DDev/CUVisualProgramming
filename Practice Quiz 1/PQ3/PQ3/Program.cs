using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQuestion

{
    class Program
    {
        static void Main(string[] args)
        {
            //User input for their name
            String name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            //Takes into account each character in the previously entered string
            foreach (char c in name)
            {
                //Prints each character on a separate line
                Console.WriteLine(c);
            }
            
            int number;
            //Asks the user for their favorite number
            Console.WriteLine("What is your favorite number?");
            number = Int32.Parse(Console.ReadLine());

            //Takes favorite number and multiplies it by 2
            int newValue = 2 * number;
            Console.WriteLine(name + " your favorite number is " + number + " and 2 x " + number + " is: " + newValue);
            Console.ReadKey();
        }
    }
}
