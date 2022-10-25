using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeFactorial
    {
        //FEITO
        public static int Factorial(int n)
        {

            switch (n)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException();
                case > 12:
                    throw new ArgumentOutOfRangeException();
                case 0:
                    return 1;
                case 1:
                    return 1;
            }

            var k = n * (n - 1);
            n--;
            while (n != 1)
            {
                k *= (n - 1);
                n--;
            }
            return k;
        }
    }
}
//MELHOR JEITO
//public static int Factorial(int n)
//{
//    if (n < 0 || n > 12)
//        throw new ArgumentOutOfRangeException();
//    return n > 0 ? n * Factorial(n - 1) : 1;
//}
//}