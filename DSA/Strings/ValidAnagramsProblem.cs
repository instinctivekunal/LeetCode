namespace DSA_C.Strings
{
    public class ValidAnagramsProblem
    {
        public void Start()
        {
            string s = "eat";
            string t = "tka";
            Console.WriteLine(string.Join(",", IsAnagram(s,t)));
        }

         bool IsAnagram(string s, string t) 
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for(int i=0; i<s.Length; i++)
            {
                if(map.ContainsKey(s[i]))
                    map[s[i]] += 1;
                else
                    map.Add(s[i], 1);
            }
            for(int i=0; i<t.Length; i++)
            {
                if(map.ContainsKey(t[i]))
                    map[t[i]] -= 1;
                else
                    return false;
            }
            foreach(char key in map.Keys)
            {
                if(map[key] != 0)
                    return false;
            }
            return true;
        }
    }
}