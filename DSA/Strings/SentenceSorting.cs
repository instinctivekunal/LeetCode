namespace DSA_C.Strings
{
    public class SentenceSorting
    {
        public void Start()
        {
            string s = "is2 sentence4 This1 a3";
            Console.WriteLine(SortSentence(s));
        }

         string SortSentence(string s) 
        {
            string[] words = s.Split(" ");
            string[] ans = new string[words.Length];
            foreach(string word in words)
            {
                int last = word.Length-1;
                ans[word[last]-'1'] = word.Substring(0, last);
            }
            return string.Join(" ", ans);
        }
    }
}