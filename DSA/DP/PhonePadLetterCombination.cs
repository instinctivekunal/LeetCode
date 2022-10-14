namespace DSA_C.DP
{
    public class PhonePadLetterCombination
    {
        // https://leetcode.com/problems/letter-combinations-of-a-phone-number/
        public void Start()
        {
            string n = "23";
            Console.WriteLine(string.Join(" ", LetterCombinations(n)));
        }

        IList<string> LetterCombinations(string digits) {
            if (digits.Length == 0) return new List<string>();
            string[] map = new string[] {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
            return Combinations("", digits, map);
        }

        IList<string> Combinations(string p, string up, string[] map)
        {
            if (up.Length == 0) {
                List<string> ans = new List<string>();
                ans.Add(p);
                return ans;
            }
            int digit = up[0] - '0';
            List<string> list = new List<string>();
            foreach(char ch in map[digit])
            {
                list.AddRange(Combinations(p+ch, up.Substring(1), map));
            }
            return list;
        }
    }
}