namespace DSA_C.Recursion
{
    public class KthSymbolGrammar
    {
        // https://leetcode.com/problems/k-th-symbol-in-grammar/
        public void Start()
        {
            int n = 4;
            int k = 7;
            Console.WriteLine(KthGrammar(n, k));
        }

         int KthGrammar(int n, int k) 
        {
            if (n==1) return 0;
            int parent = KthGrammar(n-1, (k+1)/2);
            if (k%2 == 0)
                return parent == 1? 0 : 1;
            else
                return parent;
        }
    }
}