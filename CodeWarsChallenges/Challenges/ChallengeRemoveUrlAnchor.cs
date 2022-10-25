using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges
{
    public class ChallengeRemoveUrlAnchor
    {
        public static string RemoveUrlAnchor(string url)
        {
            // TODO: complete
            return url.Contains('#') ? (url.Remove(url.IndexOf("#"))) : (url);
        }
    }
}
