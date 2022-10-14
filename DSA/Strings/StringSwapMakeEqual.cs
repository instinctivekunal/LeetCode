using System.Text;
namespace DSA_C.Strings
{
    public class StringSwapMakeEqual
    {
        public void Start()
        {
            string s = "aa";
            string t = "bb";
            Console.WriteLine(AreAlmostEqual(s, t));
        }

        bool AreAlmostEqual(string s1, string s2) {
            if (s1 == s2) return true;
            if (s1.Length != s2.Length) return false;            
            int pos = -1;
            for (int i=0; i<s1.Length; i++)
            {   
                if (s1[i] != s2[i]) {
                    if (pos < 0) pos=i;
                    else if (pos >= 0) {
                        s2 = Swap(s2, i, pos);
                        break;
                    }
                }
            }
            return (s1 == s2);
        }

        string Swap(string str, int i, int j)
        {
            StringBuilder sb = new StringBuilder(str);
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
            return sb.ToString();
        }

    }
}