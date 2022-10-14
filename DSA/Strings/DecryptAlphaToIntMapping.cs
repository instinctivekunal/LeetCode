using System.Text;

namespace DSA_C.Strings
{
    public class DecryptAlphaToIntMapping
    {
        // https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
        public void Start()
        {
            string s = "10#11#12";
            Console.WriteLine(FreqAlphabets(s));
        }

        string FreqAlphabets(string s) 
        {
            StringBuilder sb = new StringBuilder();
            for(int i=s.Length-1; i>=0; i--)
            {
                if(s[i] == '#')
                {
                    i-=2;
                    sb.Append((char)(Int32.Parse(s.Substring(i,2)) + 'a'-1)); //Gets the ASCII value & converts to desired char
                }
                else
                    sb.Append((char)(s[i]-'0'+'a'-1));
            }
            return string.Concat(sb.ToString().Reverse());
        }
    }
}