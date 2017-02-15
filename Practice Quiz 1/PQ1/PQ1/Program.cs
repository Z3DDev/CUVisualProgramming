using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0} to my quiz", name);

            Console.WriteLine("What is your favorite number?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is an interesting number", number);

            Console.WriteLine("{0} x 3 = {1}", number, number*3);
            Console.ReadLine();

        }
    }
}
