using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Account
    {
        int balance;

        public void deposit(int amount)
        {

        }

        public bool withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }
            else
                return false;
        }

        String ToString()
        {
            return "Generic Account " + balance;
        }

    }
}
