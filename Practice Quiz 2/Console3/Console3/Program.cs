using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            float final = 0;

            Console.WriteLine("Please Enter a Number or 'quit'");

            while (Console.ReadLine() != "quit")
            {
                string input = Console.ReadLine();
                float number = float.Parse(input);
                final += number;
                Console.WriteLine("Please Enter a Number or 'quit'");
            }
            else
            {
                Console.WriteLine(final);
            }

        }
    }
}
