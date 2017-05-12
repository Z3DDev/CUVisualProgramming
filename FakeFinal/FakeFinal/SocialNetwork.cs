using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFinal
{
    class SocialNetwork
    {
        public int numFriends;

        public SocialNetwork()
        {

        }

        public SocialNetwork(int numFriends)
        {
            this.numFriends = numFriends;
        }

        public int getnumFriends()
        {
            return numFriends;
        }

        public void setnumFriends(int newnumFriends)
        {
            numFriends = newnumFriends;
        }

        public override string ToString()
        {
            return "This Social Network account has: " + numFriends + " friends/followers";
        }
    }
}
