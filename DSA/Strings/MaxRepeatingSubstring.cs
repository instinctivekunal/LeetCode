namespace DSA_C.Strings
{
    public class MaxRepeatingSubstring
    {
        public void Start()
        {           
            string s = "aaabaaaabaaabaaaabaaaabaaaabaaaaba";
            string w = "aaaba";
            Console.WriteLine(MaxRepeating(s, w));
        }

         int MaxRepeating(string sequence, string word) 
        {
            int max = 0;
            string temp = word;
            while(sequence.Contains(temp))
            {
                max++;
                temp += word;
            }
            return max;
        }
    }
}