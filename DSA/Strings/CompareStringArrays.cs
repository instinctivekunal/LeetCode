namespace DSA_C.Strings
{
    public class CompareStringArrays
    {
        public void Start()
        {
            string[] w1 = new string[] {"ab", "c"};
            string[] w2 = new string[] {"a", "bc"};
            Console.WriteLine(ArrayStringsAreEqual(w1, w2));
        }

        bool ArrayStringsAreEqual(string[] word1, string[] word2) 
        {
            //return (string.Join("", word1)==string.Join("", word2));
            //return string.Concat(word1)==string.Concat(word2);
            string s1="", s2="";
            foreach(string s in word1)
                s1+=s;
            foreach(string s in word2)
                s2+=s;
            return s1.Equals(s2);
        }
    }
}