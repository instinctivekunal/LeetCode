namespace DSA_C.Strings
{
    public class IsomorphicStringCheck
    {
        public void Start()
        {
            string s = "add";
            string t = "egg";
            Console.WriteLine(IsIsomorphic(s, t));
        }

        bool IsIsomorphic(string s, string t) {
            Dictionary<char, char> first = new Dictionary<char, char>();
            Dictionary<char, char> second = new Dictionary<char, char>();

            for (int i=0; i<s.Length; i++)
            {
                if (!first.ContainsKey(s[i])) 
                    first.Add(s[i], t[i]);
                if (!second.ContainsKey(t[i])) 
                    second.Add(t[i], s[i]);
                if (first[s[i]] != t[i] || second[t[i]] != s[i])
                    return false;
            }
            return true;
        }
    }
}