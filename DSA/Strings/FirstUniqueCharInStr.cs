namespace DSA_C.Strings
{
    public class FirstUniqueCharInStr
    {
        public void Start()
        {
            string s = "leetcode";
            Console.WriteLine(FirstUniqChar(s));
            Console.WriteLine(CanConstruct("aa", "aab"));
        }

        // https://leetcode.com/problems/first-unique-character-in-a-string/
        int FirstUniqChar(string s) {
            int[] freq = new int[26];
            foreach(char ch in s)
                freq[ch-'a']++;
            for(int i=0; i<s.Length; i++)
                if (freq[s[i]-'a'] == 1)
                    return i;
            return -1;
        }

        // https://leetcode.com/problems/ransom-note/
        public bool CanConstruct(string ransomNote, string magazine) 
        {
            int[] freq = new int[26];
            foreach(char ch in magazine)
                freq[ch-'a']++;
            for(int i=0; i<ransomNote.Length; i++)
                if (--freq[ransomNote[i]-'a'] < 0)
                    return false;
            return true;
        }
    }
}