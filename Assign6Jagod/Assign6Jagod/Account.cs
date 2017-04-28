using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Account
    {
        //Public variable Balance
        public int balance;

        //Constructor for Accounts, takes in Balance
        public Account(int balance)
        {
            this.balance = balance;
        }

        //Method for Deposits into Balance
        public void deposit(int amount)
        {
            if (amount >= balance)
            {
                balance = balance + amount;
            }
        }

        //Method of Withdrawing from Balance
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

        //Getter for Balance
        public int getBalance()
        {
            return balance;
        }

        //Setter for Balance
        public void setBalance(int newBalance)
        {
            balance = newBalance;
        }

        //ToString for Account
        public override String ToString()
        {
            return "Generic Account " + balance;
        }

    }
}
