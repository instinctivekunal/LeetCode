namespace DSA_C.Strings
{
    public class ReversePrefixWord
    {
        public void Start()
        {
            string w = "abcdefd";
            char ch = 'd';
            Console.WriteLine(ReversePrefix(w, ch));
        }

         string ReversePrefix(string word, char ch) 
        {
            int idx = word.IndexOf(ch);
            if (idx < 0) 
                return word;
            string rev = Reverse(word.Substring(0, ++idx));
            return string.Concat(rev, word.Substring(idx));
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