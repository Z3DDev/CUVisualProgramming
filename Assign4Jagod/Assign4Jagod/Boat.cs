using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class Boat : Vehicle
    {
        int numMotors;

        public Boat(string color, string name, int topSpeed, int numMotors) : base(color, name, topSpeed)
        {
            this.numMotors = numMotors;
        }

        public override string ToString()
        {
            return base.ToString() + " and the number of motors is " + numMotors;
        }
    }
}
