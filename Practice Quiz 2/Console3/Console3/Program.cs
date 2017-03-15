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
            bool quit = false;

            while(quit == false)
            {
                Console.WriteLine("Please Enter a Number or 'quit'");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                else
                {
                    float number = float.Parse(input);
                    final += number;
                }
            }
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}
