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
            Checking CheckA = new Checking(15);
            Checking CheckB = new Checking(10);
            Saving SaveA = new Saving(1, 10);
            Saving SaveB = new Saving(5, 15);
            Person PersonA = new Person("Bob", CheckA, SaveA);
            Person PersonB = new Person("Alice", CheckB, SaveB);


        }
    }
}
