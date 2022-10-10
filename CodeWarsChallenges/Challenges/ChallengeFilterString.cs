using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    // FEITO!
    public class ChallengeFilterString
    {

        public static int FilterString(string s)
        {
            //Your code goes here
            int number;
            var newS = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {

                if (int.TryParse(s[i].ToString(), out number))
                {
                    newS = newS.Append(s[i]);                    
                }

            }

            Console.WriteLine(newS);
            return int.Parse(newS.ToString());

        }

    }
}

// MELHOR JEITO
//public static int FilterString(string s)
//{
//    return int.Parse(new String(s.Where(Char.IsDigit).ToArray()));
//}