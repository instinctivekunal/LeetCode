namespace DSA_C.Strings
{
    public class VowelPermutations
    {
        // https://leetcode.com/problems/count-vowels-permutation/description/
        
        // Each vowel 'a' may only be followed by an 'e'.
        // Each vowel 'e' may only be followed by an 'a' or an 'i'.
        // Each vowel 'i' may not be followed by another 'i'.
        // Each vowel 'o' may only be followed by an 'i' or a 'u'.
        // Each vowel 'u' may only be followed by an 'a'.
        // === In other words: 
        // 'a' can be followed by {'e'}
        // 'e' can be followed by {'a', 'i'}
        // 'i' can be followed by {'a', 'e', 'o', 'u'}
        // 'o' can be followed by {'i', 'u'}
        // 'u' can be followed by {'a'}
        // === In other words:
        // 'a' can follow {'e', 'i', 'u'}
        // 'e' can follow {'a', 'i'}
        // 'i' can follow {'e', 'o'}
        // 'o' can follow {'i'}
        // 'u' can follow {'i', 'o'}

        public void Start()
        {
            int n = 5;
            Console.WriteLine(CountVowelPermutation(n));
        }

        int CountVowelPermutation(int n) {
            int mod = 1000000007;
            long sum = 0;
            long[] vowels = new long[] {1,1,1,1,1}; // a-0, e-1, i-2, o-3, u-4
            for (int i=1; i<n; i++)
            {
                long[] tmp = new long[5];
                tmp[0] = (vowels[1] + vowels[2] + vowels[4]) % mod;
                tmp[1] = (vowels[0] + vowels[2]) % mod;
                tmp[2] = (vowels[1] + vowels[3]) % mod;
                tmp[3] = (vowels[2]) % mod;
                tmp[4] = (vowels[2] + vowels[3]) % mod;
                vowels = tmp;
            }
            foreach(long val in vowels)
                sum = (sum + val) % mod;
            return (int)sum;
        }
    }
}