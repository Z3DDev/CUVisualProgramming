using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class MonsterTruck : Car
    {
        int wheelSize;

        public MonsterTruck(string color, string name, int topSpeed, int numWheels, int numDoors, int wheelSize) : base(color, name, numDoors, numWheels, topSpeed)
        {
            this.wheelSize = wheelSize;
        }

        public override string ToString()
        {
            return base.ToString() + " and the wheel size is " + wheelSize + "ft ";
        }
    }
}
