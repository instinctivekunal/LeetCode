namespace DSA_C.Strings
{
    public class FindDifference
    {
        public void Start()
        {
            string s = "abbccd";
            string t = "abbccde";
            Console.WriteLine(FindTheDifference(s, t));
        }

        char FindTheDifference(string s, string t) {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (char ch in t) {
                if (chars.ContainsKey(ch))
                    chars[ch]++;
                else
                    chars.Add(ch, 1);                    
            }
            foreach (char ch in s)
            {
                if (chars.ContainsKey(ch))
                    if (chars[ch] == 1)
                        chars.Remove(ch);
                    else
                        chars[ch]--;
            }
            return chars.Keys.First();
        }
    }
}