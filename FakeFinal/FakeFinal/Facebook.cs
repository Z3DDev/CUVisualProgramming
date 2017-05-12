using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFinal
{
    class Facebook : SocialNetwork
    {
        public Facebook()
        {

        }

        public Facebook(int numFriends) : base(numFriends)
        {

        }

        public void addFriend()
        {
            int additionalFriend = getnumFriends()+1;
            setnumFriends(additionalFriend);
        }

        public override string ToString()
        {
            return "This Facebook account has: " + getnumFriends() + " friends";
        }
    }
}
