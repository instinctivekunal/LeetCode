namespace DSA_C.Rest
{
    public class HammingWeightProblem
    {
        // https://leetcode.com/problems/number-of-1-bits/
        public void Start()
        {
            ulong n = 0000000000000000000000011001011;            
            Console.WriteLine(HammingWeight(n));
            uint n1 = 00000000000000000000000000001011;
            Console.WriteLine(ReverseBits(n1));
        }        
    
        int HammingWeight(ulong n) {
            int ans = 0;
            while (n != 0)
            {
                ans += (int)(n&1);
                n >>= 1;
            }
            return ans;
        }

        uint ReverseBits(uint n) {
            if (n == 0) return 0;
            uint rev = 0;
            for (var i = 31 ; i >= 0; i--)
            {
                rev |= (n & 1) << i;
                n >>= 1;
            }
            return rev;
        }
    }
}