using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFinal
{
    class Person
    {
        private string name;
        private Facebook fbAccount;
        private Twitter twAccount;

        public Person()
        {

        }

        public Person(string name, Facebook fbAccount, Twitter twAccount)
        {
            this.name = name;
            this.fbAccount = fbAccount;
            this.twAccount = twAccount;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public Facebook getfbAccount()
        {
            return fbAccount;
        }

        public void setfbAccount(Facebook newfbAccount)
        {
            fbAccount = newfbAccount;
        }

        public Twitter gettwAccount()
        {
            return twAccount;
        }

        public void settwAccount(Twitter newtwAccount)
        {
            twAccount = newtwAccount;
        }

        public override string ToString()
        {
            return name + "\n" + fbAccount.ToString() + "\n" + twAccount.ToString() + "\n\n";
        }
    }
}
