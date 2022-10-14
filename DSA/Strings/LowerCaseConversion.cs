namespace DSA_C.Strings
{
    public class LowerCaseConversion
    {
        public void Start()
        {
            string s = "@KUNAL";
            Console.WriteLine(ToLowerCase(s));
        }

         string ToLowerCase(string s) 
        {
            string ans="";
            foreach(char c in s)
            {
                if (c >= 65 && c <=90)
                    ans+=(char)(c+32);
                else
                    ans+=c;
            }
            return ans;
        }
    }
}