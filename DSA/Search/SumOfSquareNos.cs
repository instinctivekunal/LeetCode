namespace DSA_C.Search
{
    public class SumOfSquareNos
    {
        // https://leetcode.com/problems/sum-of-square-numbers/
        public void Start()
        {
            Console.WriteLine(JudgeSquareSum(5));
        }

        bool JudgeSquareSum(int c) {
            long l=0, r= (long)(Math.Sqrt(c));
            while (l<=r) {
                long mid = (l*l + r*r);
                if (mid == (long)c) 
                    return true;
                if (mid < c) 
                    l++;
                else 
                    r--;
            }
            return false;
        }
        
    }
}