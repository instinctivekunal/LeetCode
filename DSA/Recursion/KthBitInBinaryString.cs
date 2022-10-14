namespace DSA_C.Recursion
{
    public class KthBitInBinaryString
    {
        // https://leetcode.com/problems/find-kth-bit-in-nth-binary-string/
        public void Start()
        {
            int n = 4;
            int k = 15;
            Console.WriteLine(FindKthBit(n, k));
        }

         char FindKthBit(int n, int k) {
            if (n == 1) {
                return '0';
            }
            int len = (1 << n) - 1;
            if (k == len / 2 + 1) {
                return '1';
            } else if (k > len / 2 + 1) {
                return FindKthBit(n - 1, len - k + 1) == '0' ? '1' : '0';
            } else {
                return FindKthBit(n - 1, k);
            }
        }       
    }
}