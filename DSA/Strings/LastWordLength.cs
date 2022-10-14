namespace DSA_C.Strings
{
    public class LastWordLength
    {
        public void Start()
        {
            string s = "   fly me   to   the moon  ";
            Console.WriteLine(LengthOfLastWord(s));
        }

        int LengthOfLastWord(string s) 
        {
            string[] split = s.Trim().Split(" ");
            return split[split.Length-1].Length;
        }
    }
}