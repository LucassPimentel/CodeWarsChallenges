using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeDisemvowel
    {
        //FEITO!
        public static void Disemvowel(string str)
        {
            string newStr = str;

            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiou".Contains(str.ToLower()[i]))
                {
                    newStr = newStr.Replace(str[i].ToString(), "");
                }
            }
            Console.WriteLine(newStr);
        }
    }
}
//MELHOR JEITO
//public static string Disemvowel(string str)
//{
//    return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
//}