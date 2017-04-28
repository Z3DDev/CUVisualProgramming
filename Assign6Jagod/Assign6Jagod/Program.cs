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
            Checking CheckB = new Checking(20);

            //Instances of Savings
            Saving SaveA = new Saving(5, 10);
            Saving SaveB = new Saving(1, 15);

            //Instance of Persons
            Person PersonA = new Person("Alice", CheckA, SaveA);
            Person PersonB = new Person("Bob", CheckB, SaveB);

            //Print Persons
            Console.WriteLine(PersonA);
            Console.WriteLine(PersonB);

            //Checking Balance Change
            Checking newCheckB = new Checking(10);
            PersonB.setaccountC(newCheckB);

            //Saving Interest Change
            Saving newSaveA = new Saving(1, 10);
            PersonA.setaccountS(newSaveA);

            //Print Persons
            Console.WriteLine(PersonA);
            Console.WriteLine(PersonB);

            //Withdraw
            CheckB.withdraw(9);
            CheckB.withdraw(8);

            //Print Person
            Console.WriteLine(PersonB);

            //Deposit
            SaveA.deposit(100);

            //Print Person
            Console.WriteLine(PersonA);
            Console.ReadKey();
        }
    }
}
