using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6Jagod
{
    class Person
    {
        public String name;
        private static Checking accountC;
        private static Saving accountS;

        public Person(string name, Checking accountC, Saving accountS)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override String ToString()
        {
            return "Owner " + name + "\n Account infochecking " + accountC.ToString() + " saving " + accountS.ToString();
        }
    }
}
