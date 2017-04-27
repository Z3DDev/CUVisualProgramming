using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    //Checking inherits Account
    class Checking : Account
    {
        //Checking Constructor takes in balance, extended from Account
        public Checking(int balance) : base(balance)
        {
            this.balance = balance;
        }

        public override String ToString()
        {
            return "Checking Account balance" + balance;
        }
    }
}
