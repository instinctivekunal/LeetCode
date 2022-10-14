namespace DSA_C.Strings
{
    public class LongestSubStringWORepeatChars
    {
        public void Start()
        {
            string s = "dvdf";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        int LengthOfLongestSubstring(string s) 
        {            
            int max = 0;
            Dictionary<char, int> inSet = new Dictionary<char, int>();
            for (int i=0; i<s.Length; i++)
            {
                char c = s[i];
                if (inSet.ContainsKey(c)) {
                    i = inSet[c];
                    inSet.Clear();
                }
                else
                {
                    inSet.Add(c, i);
                    max = Math.Max(max, inSet.Count);
                }
            }
            return max;
        }

        int LengthOfLongestSubstring1(string s) 
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int max = 0, i = 0, j = 0;
            HashSet<char> inSet = new HashSet<char>();
            while (i < s.Length)
            {
                if (inSet.Contains(s[i])) {
                    max = Math.Max(max, inSet.Count);
                    inSet.Remove(s[j]);
                    j++;
                }
                else {
                    inSet.Add(s[i]);
                    i++;
                }
            }
            return Math.Max(max, inSet.Count);
        }
    }
}