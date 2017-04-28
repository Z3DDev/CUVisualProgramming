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

        //Getter for Name
        public string getName()
        {
            return name;
        }

        //Setter for Name
        public void setName(string newName)
        {
            name = newName;
        }

        //Getter for AccountC (Checking)
        public Checking getaccountC()
        {
            return accountC;
        }

        //Setter for AccountC (Checking)
        public void setaccountC(Checking newaccountC)
        {
            accountC = newaccountC;
        }

        //Getter for AccountS (Saving)
        public Saving getaccountS()
        {
            return accountS;
        }

        //Setter for AccountS (Saving)
        public void setaccountS(Saving newaccountS)
        {
            accountS = newaccountS;
        }

        //ToString for Person
        public override string ToString()
        {
            return "Owner: " + name + "\n Account Infochecking " + accountC.ToString() + " Saving " + accountS.ToString();
        }
    }
}
