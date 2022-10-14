using System.Text;

namespace DSA_C.Strings
{
    public class ReverseWordsIII
    {
        public void Start()
        {
            string s = "Let's take LeetCode contest";
            Console.WriteLine(ReverseWords(s));
        }

         string ReverseWords(string s) 
        {
            StringBuilder sb = new StringBuilder();
            foreach(string word in s.Split(" "))
            {
                sb.Append(Reverse(word));
                sb.Append(" ");
            }
            return sb.ToString().Trim();
        }

         string Reverse(string str)
        {
            string ans = "";
            for(int i= str.Length-1; i>=0; i--)
            {
                ans += str[i];
            }
            return ans;
        }
    }
}