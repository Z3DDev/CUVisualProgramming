using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFinal
{
    class SocialNetworkTest
    {
        static void Main(string[] args)
        {
            Facebook fb = new Facebook(25);
            Twitter tw = new Twitter("Merry Christmas", 800);
            Person p = new Person("Alice", fb, tw);
            Console.WriteLine(p);

            fb.setnumFriends(50);

            tw.setlastTweet("Happy New Year");
            Console.WriteLine(p);
            p.gettwAccount().setlastTweet("Happy Holidays");
            Console.WriteLine(p);

            fb.addFriend();
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
