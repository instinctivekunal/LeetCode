namespace DSA_C.Strings
{
    public class StringAsSubStringInWord
    {
        public void Start()
        {
            string[] s = new string[] {"a", "abc", "bc", "d"};
            string word = "abc";
            Console.WriteLine(NumOfStrings(s, word));
        }

         int NumOfStrings(string[] patterns, string word)
        {
            int cnt=0;
            foreach(string str in patterns)
            {
                if(word.Contains(str)) cnt++;
            }
            return cnt;
        }
    }
}