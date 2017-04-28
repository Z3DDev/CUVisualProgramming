using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    //Saving inherits Account
    class Saving : Account
    {
        //The Saving's Class requires it's own variable to calculate accured interest
        int interest;
        
        //Saving Constructor takes in the interest value and balance value, the latter extended from Account
        public Saving(int interest, int balance) : base(balance)
        {
            this.balance = balance;
            this.interest = interest;
        }

        //Getter for Saving
        public int getSaving()
        {
            return interest + balance;
        }

        //Setter for Saving
        public void setSaving(int newInterest, int newBalance)
        {
            interest = newInterest;
            balance = newBalance;
        }

        //ToString for Saving
        public override String ToString()
        {
            return "Account Balance: " + balance + " Interest: " + interest;
        }
    }
}
