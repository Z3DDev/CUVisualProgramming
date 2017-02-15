using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                    break;

                if (i % 2 == 0)
                    continue;

                Console.Write("{0} ", i);
            }

            //For Each Loop
            string[] names = { "Cheryl", "Joe", "Matt", "Robert" };
            foreach (string person in names)
            {
                Console.WriteLine("{0} ", person);
            }
        }
    }
}
