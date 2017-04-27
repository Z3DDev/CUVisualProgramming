using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Saving : Account
    {
        int interest;

        String ToString()
        {
            return "Saving Account balance " + balance + "interest " + interest;
        }
    }
}
