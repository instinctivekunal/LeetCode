namespace DSA_C.Arrays
{
    public class SignOfProductOfArray
    {
        // https://leetcode.com/problems/sign-of-the-product-of-an-array/
        public void Start()
        {
            int[] nums = {-1,-2,-3,-4,3,2,1,-5};
            Console.WriteLine(ArraySign(nums));
        }

        int ArraySign(int[] nums) {
            int ans = 1;
            foreach(int num in nums)
            {
                if (num == 0) return 0;
                if (num < 0) ans *= -1;
            }
            return ans;
        }
    }
}