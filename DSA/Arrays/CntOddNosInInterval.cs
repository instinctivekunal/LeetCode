namespace DSA_C.Arrays
{
    public class CntOddNosInInterval
    {
        // https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
        public void Start()
        {
            Console.WriteLine(CountOdds(3,7));
        }

        int CountOdds(int low, int high) {
            int n = high-low+1;
            if (low%2 != 0 && high%2 != 0)
                return n/2 + 1;
            return n/2;
        }
    }
}