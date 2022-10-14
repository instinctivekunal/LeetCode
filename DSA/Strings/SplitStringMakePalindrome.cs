namespace DSA_C.Strings
{
    public class SplitStringMakePalindrome
    {
        public void Start()
        {
            string a="xbdef";
            string b="xracx";
            Console.WriteLine(CheckPalindromeFormation(a,b));
        }

         bool CheckPalindromeFormation(string a, string b) 
        {
            return CheckFormation(a,b) || CheckFormation(b,a);
        }

         bool CheckFormation(string a, string b)
        {
            int start=-1, end=a.Length;
            while (start < end)
            {
                if(a[++start] != b[--end])
                    break;
            }
            return IsPalindrome(a, start, end) || IsPalindrome(b, start, end);
        }

         bool IsPalindrome(string s, int start, int end)
        {
            while(start<end)
            {
                if(s[start++] != s[end--])
                    return false;
            }
            return true;
        }
    }
}