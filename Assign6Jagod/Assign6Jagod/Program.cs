using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking CheckA = new Checking();
            Checking CheckB = new Checking();
            Saving SaveA = new Saving();
            Saving SaveB = new Saving();
            Person PersonA = new Person("Bob", CheckA, SaveA);
            Person PersonB = new Person("Alice", CheckB, SaveB);

        }
    }
}
