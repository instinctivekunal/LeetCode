namespace DSA_C.Recursion
{
    public class WordBreakDP
    {
        // https://leetcode.com/problems/word-break/
        public void Start()
        {
            string s = "leetcode";
            string[] wd = new string[] {"leet", "code"};
            Console.WriteLine(WordBreak(s, wd));
        }

         bool WordBreak(string s, IList<string> wordDict)
        {
            int length = s.Length;
            bool[] dp = new bool[length + 1];
            dp[0] = true;

            for (int len = 1; len <= length; len++)
            {
                for (int i = 0; i < len; i++)
                {
                    if (dp[i] && wordDict.Contains(s.Substring(i, len-i)))
                    {
                        dp[len] = true; 
                        break;
                    }
                }
            }
            return dp[length];
        }
    }
}