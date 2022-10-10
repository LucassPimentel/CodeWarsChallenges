using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeGrowingPlant
    {
        //FEITO!
        public static void GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            //coding and coding..
            var height = 0;
            var days = 0;

            while (height < DesiredHeight)
            {
                height += UpSpeed;
                days++;
                if (days > 1)
                {
                    height -= DownSpeed;
                }
            }


            Console.WriteLine($"Altura: {height} - Dias {days}");


        }


    }
}
