namespace CodeWarsChallenges.Challenges
{
    public class ChallengeGetVowelCount
    {
        //FEITO!
        public static void GetVowelCount(string str)
        {
            var vowels = new string[] { "a", "e", "i", "o", "u" };
            int vowelCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str.ToLower()[i].ToString()))
                {
                    vowelCount++;
                }
            }

            // Your code here

            Console.WriteLine(vowelCount);
        }
    }
}

//MELHOR JEITO!
//public static int GetVowelCount(string str)
//{
//    return str.Count(i => "aeiou".Contains(i));
//}
