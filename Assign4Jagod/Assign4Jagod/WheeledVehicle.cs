using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class WheeledVehicle : Vehicle
    {
        int numWheels;

        public WheeledVehicle(string color, string name, int topSpeed, int numWheels) : base(color, name, topSpeed)
        {
            this.numWheels = numWheels;
        }

        public override string ToString()
        {
            return base.ToString() + " and the number of wheels is " + numWheels;
        }
    }
}
