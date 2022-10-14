namespace DSA_C.Strings
{
    public class SentenceSimilarityIII
    {
        public void Start()
        {
            string s1 = "a";
            string s2 = "a aa a";
            Console.WriteLine(AreSentencesSimilar(s1, s2));
            Console.WriteLine(Try(s1, s2));
        }

         bool AreSentencesSimilar(string sentence1, string sentence2) 
        {
            if (sentence1 == sentence2) return true;
            if (sentence1.Length < sentence2.Length) return AreSentencesSimilar(sentence2, sentence1);

            string[] s1 = sentence1.Split(" ");
            string[] s2 = sentence2.Split(" ");
            int l1 = s1.Length;
            int l2 = s2.Length;

            int pos=0, match=0;
            while (pos<l2 && s1[pos] == s2[pos])
            {
                match++;
                pos++;
            }
            
            pos = l2-1;
            int pos1 = l1-1;
            while (pos>=0 && s1[pos1] == s2[pos])
            {
                match++;
                pos--;
                pos1--;
            }

            return match < l2 ? false: true;
        }

         bool Try(string sentence1, string sentence2) {
            var s1 = sentence1.Split(' ');
            var s2 = sentence2.Split(' ');
            
            if(s1.Length<s2.Length)   // we want to keep l1 longer/equal to l2
            {
                var temp = s1;
                s1 = s2;
                s2 = temp;
            }
            int i=0,j=0,l1=s1.Length,l2=s2.Length;
            while(i<l2 && s1[i]==s2[i])
                i++;
            while(l1-1-j>=0 && l2-1-j >= 0 && s1[l1-1-j]==s2[l2-1-j])
                j++;
            
            if(i==0 && j==0) return false;  // no match found from either end
            if(i+j<l2)  return false;   // not all characters matched from smaller sentence
            return true;        
        }
    }
}