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

        public override String ToString()
        {
            return "Saving Account balance " + balance + "interest " + interest;
        }
    }
}
