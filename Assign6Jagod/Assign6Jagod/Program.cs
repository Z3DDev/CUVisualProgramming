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
            //Instances of Checking
            Checking CheckA = new Checking(15);
            Checking CheckB = new Checking(10);

            //Instances of Savings
            Saving SaveA = new Saving(1, 10);
            Saving SaveB = new Saving(5, 15);

            //Instance of Persons
            Person PersonA = new Person("Bob", CheckA, SaveA);
            Person PersonB = new Person("Alice", CheckB, SaveB);

            //Print Persons
            Console.WriteLine(PersonB);
            Console.WriteLine(PersonA);

            //Checking Balance Change


            //Saving Interest Change


            //Print Persons
            Console.WriteLine(PersonB);
            Console.WriteLine(PersonA);

            //Withdraw


            //Print Person
            Console.WriteLine(PersonA);

            //Deposit


            //Print Person
            Console.WriteLine(PersonB);
            Console.ReadKey();
        }
    }
}
