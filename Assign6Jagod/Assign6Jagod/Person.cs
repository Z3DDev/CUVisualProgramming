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
        public string name;
        //Private Setup of Checking Account
        public Checking accountC;
        //Private Setup of Savings Account
        public Saving accountS;

        //Contrustor for Person, takes in Name, Checking, and Saving
        public Person(string name, Checking accountC, Saving accountS)
        {
            this.name = name;
            this.accountC = accountC;
            this.accountS = accountS;
        }

        //Retrieves name from program input
        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Owner " + name + "\n Account infochecking " + accountC.ToString() + " saving " + accountS.ToString();
        }
    }
}
