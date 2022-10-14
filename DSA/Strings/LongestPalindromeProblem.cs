namespace DSA_C.Strings
{
    public class LongestPalindromeProblem
    {
        public void Start()
        {
            string s = "abccccdd";
            Console.WriteLine(LongestPalindrome(s));
        }

        int LongestPalindrome(string s) {
            HashSet<char> ans = new HashSet<char>();
            int count = 0;
            foreach (char ch in s)
            {
                if (ans.Contains(ch)) {
                    ans.Remove(ch);
                    count += 2;                    
                } else
                    ans.Add(ch);
            }
            if (ans.Count > 0)
                count++;
            return count;
        }
    }
}