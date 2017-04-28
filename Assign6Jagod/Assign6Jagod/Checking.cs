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
        
        //Getter for Checking
        public int getChecking()
        {
            return balance;
        }

        //Setter for Checking
        public void setChecking(int newBalance)
        {
            balance = newBalance;
        }

        //ToString for Checking
        public override String ToString()
        {
            return "Checking Account Balance: " + balance;
        }
    }
}
