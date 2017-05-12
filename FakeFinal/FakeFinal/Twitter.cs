using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFinal
{
    class Twitter : SocialNetwork
    {
        public string lastTweet;

        public Twitter()
        {
           
        }

        public Twitter(string lastTweet, int numFriends) : base(numFriends)
        {
            this.lastTweet = lastTweet;
        }

        public string getlastTweet()
        {
            return lastTweet;
        }

        public void setlastTweet(string newlastTweet)
        {
            lastTweet = newlastTweet;
        }

        public override string ToString()
        {
            return "This Twitter account has: " + getnumFriends() + " followers and the last tweet is " + lastTweet;
        }
    }
}
