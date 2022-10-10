using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeFriendOrFoe
    {
        //FEITO!
        public static void FriendOrFoe(string[] names)
        {
            var friends = new List<string>();
            // Good luck!
            foreach (var name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }
            friends.ForEach(n => Console.WriteLine(n));
        }

    }
}

//MELHOR JEITO
//public static IEnumerable<string> FriendOrFoe(string[] names)
//{
//    return names.Where(name => name.Length == 4);
//}
