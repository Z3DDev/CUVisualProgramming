using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;

            while (myInt < 10)
            {
                Console.Write("{0} ", myInt);
                myInt++;
            }
        }
    }
}
