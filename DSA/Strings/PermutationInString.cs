namespace DSA_C.Strings
{
    public class PermutationInString
    {
        //https://leetcode.com/problems/permutation-in-string/
        public void Start()
        {
            string s1 = "ab";
            string s2 = "eidboaaoo";
            Console.WriteLine(CheckInclusion(s1, s2));
        }

        bool CheckInclusion(string s1, string s2) {
            s1 = Sort(s1);
            for (int i=0; i<=s2.Length-s1.Length; i++)
            {
                if (s1.Equals(Sort(s2.Substring(i, s1.Length))))
                    return true;
            }
            return false;
        }

        string Sort(string s)
        {
            char[] t = s.ToCharArray();
            Array.Sort(t);
            return new string(t);
        }

        bool CheckInclusion1(string s1, string s2) {
            List<string> list = Permutations("", s1);
            foreach(string s in list)
                if (s2.Contains(s))
                    return true;
            return false;
        }

        List<string> Permutations(string p, string up)
        {
            if(up.Length == 0)
            {
                List<string> m = new List<string>();
                m.Add(p);
                return m;
            }

            char ch = up[0];
            List<string> ans = new List<string>();
            for(int i=0; i<=p.Length; i++)
            {
                string s = p.Substring(0, i);
                string e = p.Substring(i);
                ans.AddRange(Permutations(s+ch+e, up.Substring(1)));
            }
            return ans;
        }
    }
}