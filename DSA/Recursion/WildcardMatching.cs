namespace DSA_C.Recursion
{
    public class WildcardMatching
    {
        public void Start()
        {
            string s = "abbabbbaabaaabbbbbabbabbabbbabbaaabbbababbabaaabbab";
            string p = "*aabb***aa**a******aa*";
            Console.WriteLine(IsMatch(s, p));
        }     

        bool IsMatch(string s, string p) {
            // int n = s.Length;
            // int m = p.Length;
            // bool[,] dp = new bool[n,m];
            // return PatternMatch(n-1, m-1, s, p, dp);
            return PatternMatchTabulization(s, p);
        }

        bool PatternMatchTabulization(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;
            bool[,] dp = new bool[n+1,m+1];
            // Both Strings matched
            dp[0,0] = true;
            // Pattern not available to match with Text
            for (int i=1; i<=n; i++)
                dp[i,0] = false;
            // Text is not available to match with pattern
            for (int j=1; j<=m; j++)
            {
                bool flag = true;
                for(int z=1; z<=j; z++)
                    if (pattern[z-1] != '*') {
                        flag = false;
                        break;
                    }
                
                dp[0,j] = flag;
            }

            for (int i=1; i<=n; i++)
            {
                for(int j=1; j<=m; j++)
                {
                    // Character comparison + ? pattern comparison
                    if (text[i-1] == pattern[j-1] || pattern[j-1] == '?')
                        dp[i,j] = dp[i-1, j-1];
                    // * pattern comparison
                    else if (pattern[j-1] == '*')
                        dp[i,j] = dp[i-1, j] || dp[i, j-1];
                    else dp[i,j] = false;
                }
            }
            return dp[n,m];
        }

        // Memoization
        bool PatternMatch(int i, int j, string text, string pattern, bool[,] dp)
        {
            // Base Conditions
            if (i<0 && j<0) return true; // Both Strings matched
            if (i>=0 && j<0) return false; // Pattern not available to match with Text
            // Text is not available to match with pattern
            if (i<0 && j>=0)
            {
                for(int m=0; m<=j; m++)
                    if (pattern[m] != '*') return false;
                return true;
            }

            if(dp[i,j] != false) return dp[i,j];

            // Character comparison + ? pattern comparison
            if (text[i] == pattern[j] || pattern[j] == '?')
                return dp[i,j] = PatternMatch(i-1, j-1, text, pattern, dp);
            // * pattern comparison
            if (pattern[j] == '*')
                return dp[i,j] = PatternMatch(i-1, j, text, pattern, dp) || PatternMatch(i, j-1, text, pattern, dp);
            return dp[i,j] = false;
        }

        bool PatternMatch(int i, int j, string text, string pattern)
        {
            // Base Conditions
            if (i<0 && j<0) return true; // Both Strings matched
            if (i>=0 && j<0) return false; // Pattern not available to match with Text
            // Text is not available to match with pattern
            if (i<0 && j>=0)
            {
                for(int m=0; m<=j; m++)
                    if (pattern[m] != '*') return false;
                return true;
            }

            // Character comparison + ? pattern comparison
            if (text[i] == pattern[j] || pattern[j] == '?')
                return PatternMatch(i-1, j-1, text, pattern);
            // * pattern comparison
            if (pattern[j] == '*')
                return PatternMatch(i-1, j, text, pattern) || PatternMatch(i, j-1, text, pattern);
            return false;
        }
    }
}