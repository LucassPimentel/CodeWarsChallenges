using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public  class ChallengeIsTriangle
    {
        //FEITO!
        public static bool IsTriangle(int a, int b, int c)
        {
            return (b + c > a && a + c > b && a + b > c);
        }
    }
}
//MAIS SIMPLES POSSÍVEL