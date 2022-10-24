using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeGetMiddle
    {
        public static string GetMiddle(string s)
        {
            //Code goes here!
            var idx = s.Length / 2;
            return s.Length % 2 == 0 ? ($"{s[idx - 1].ToString()}{s[idx].ToString()}") : (s[idx].ToString());

        }


    }

}
