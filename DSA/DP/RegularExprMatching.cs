namespace DSA_C.DP
{
    public class RegularExprMatching
    {
        public void Start()
        {
            string s = "aab";
            string p = "c*a*b";
            Console.WriteLine(IsMatch(s, p));
        }

        bool IsMatch(string s, string p) {
            if (p.Length == 0) 
                return (s.Length == 0);
            bool match = (s.Length != 0 && (p[0] == s[0] || p[0] == '.'));
            if (p.Length >= 2 && p[1] =='*')
                return (IsMatch(s, p.Substring(2)) || match && IsMatch(s.Substring(1), p));
            else
                return match && IsMatch(s.Substring(1), p.Substring(1));
        }


        // WildCard Matching Solution
        bool IsMatchWC(string s, string p) {
            int n = s.Length;
            int m = p.Length;
            return Matched(m-1, n-1, p, s);
        }

        bool Matched(int i, int j, string p, string s){
            if (i<0 && j<0) return true;
            if (i<0 && j>=0) return false;
            if (j<0 && i>=0) {
                for(int m=0; m<i; m++)
                    if(p[m] != '*')
                        return false;
                return true;
            }
            if (p[i] == s[j] || p[i] == '.')
                return Matched(i-1, j-1, p, s);
            if (p[i] == '*')
                return Matched(i-1, j , p, s) | Matched(i, j-1, p, s);
            return false;
        }
    }
}