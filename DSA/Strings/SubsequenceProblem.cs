namespace DSA_C.Strings
{
    public class SubsequenceProblem
    {
        public void Start()
        {
            string s = "abc";
            string t = "ahbgdc";
            Console.WriteLine(IsSubsequence(s, t));
        }

        bool IsSubsequence(string s, string t) {
            if (s.Length > t.Length) return false;
            if (s.Length == 0) return true;
            int idx=0;
            for (int i=0; i<t.Length; i++) {
                if (s[i] == t[i]) 
                    idx++;
                if (idx == s.Length) 
                    return true;
            }
            return false;
        }
    }
}