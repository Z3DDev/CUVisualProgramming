using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Person
    {
        //Setup of Name through String
        public String name;
        //Private Setup of Checking Account
        private static Checking accountC;
        //Private Setup of Savings Account
        private static Saving accountS;

        //Contrustor for Person, takes in Name, Checking, and Saving
        public Person(string name, Checking accountC, Saving accountS)
        {
            this.name = name;
        }

        //Retrieves name from program input
        public string getName()
        {
            return name;
        }

        public override String ToString()
        {
            return "Owner " + name + "\n Account infochecking " + accountC.ToString() + " saving " + accountS.ToString();
        }
    }
}
