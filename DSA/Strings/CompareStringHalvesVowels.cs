namespace DSA_C.Strings
{
    public class CompareStringHalvesVowels
    {
        public void Start()
        {
            string s = "book";
            Console.WriteLine(HalvesAreAlike(s));
        }

         bool HalvesAreAlike(string s) 
        {
            int first=0, last=s.Length-1;
            int c1=0, c2=0;
            while (first<last)
            {
                if(IsVowel(s[first++])) c1++;
                if(IsVowel(s[last--])) c2++;
            }
            return c1==c2;
        }

         bool IsVowel(char ch)
        {
            if (ch == 'a' || ch =='A' || ch == 'e' || ch =='E' || ch == 'i' || ch =='I' || ch == 'o' || ch =='O' || ch == 'u' || ch =='U')
                return true;
            return false;
        }
    }
}