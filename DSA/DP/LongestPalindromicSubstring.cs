namespace DSA_C.DP
{
    public class LongestPalindromicSubstring
    {
        // https://leetcode.com/problems/longest-palindromic-substring/
        public void Start()
        {
            string s = "babad";
            Console.WriteLine(LongestPalindrome(s));
        }

        string LongestPalindrome(string s) {
            string ans = "" ;
            int len = 0;
            for(int i=0; i<s.Length; i++)
            {
                // Odd Length
                Find(s, i, i, ref ans, ref len);
                // Even Length
                Find(s, i, i+1, ref ans, ref len);
            }
            return ans;
        }

        void Find(string s, int left, int right, ref string ans, ref int len)
        {
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                if ((right-left+1) > len) {
                    ans = s.Substring(left,(right-left+1));
                    len = ans.Length;
                }
                left -= 1;
                right += 1;
            }
        }
    }
}