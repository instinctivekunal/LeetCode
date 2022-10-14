namespace DSA_C.Strings
{
    public class ValidPalindromeII
    {
        public void Start()
        {
            string s = "Malaykalam";
            Console.WriteLine(ValidPalindrome(s));
        }

         bool ValidPalindrome(string s) 
        {
            return IsPalindrome(s, 0, s.Length-1, false);
        }

         bool IsPalindrome(string str, int start, int end, bool hasError)
        {
            while (start<end)
            {
                if(str[start] == str[end])
                {
                    start++;
                    end--;
                    continue;
                }
                if (hasError) return false;
                return IsPalindrome(str, start+1, end, true) || IsPalindrome(str, start, end-1, true);
            }
            return true;
        }
    }
}