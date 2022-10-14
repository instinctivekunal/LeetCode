namespace DSA_C.Strings
{
    public class MergeStrAlternatively
    {
        public void Start()
        {
            string w1 = "abc";
            string w2 = "pqrst";
            Console.WriteLine(MergeAlternately(w1, w2));
        }

         string MergeAlternately(string word1, string word2) 
        {
            int c1=0, c2=0;
            string ans = "";
            while(c1 < word1.Length && c2 < word2.Length)
            {
                ans += word1[c1++];
                ans += word2[c2++];
            }
            ans += word1.Substring(c1);
            ans += word2.Substring(c2);
            return ans;
        }
    }
}