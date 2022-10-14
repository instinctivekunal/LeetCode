namespace DSA_C.Recursion
{
    public class MinMaxElementArray
    {
        public void Start()
        {
            int[] nums = {1, 4, 3, -5, -4, 8, 6};
            MinMax(nums);
        }

         void MinMax(int[] nums)
        {
            Console.WriteLine(Min(nums, nums.Length));
            Console.WriteLine(Max(nums, nums.Length));
        }

         int Min(int[] A, int n)
        {
            if (n == 1)
                return A[0];
            return Math.Min(A[n-1], Min(A, n-1));
        }

         int Max(int[] A, int n)
        {
            if (n == 1)
                return A[0];
            return Math.Max(A[n-1], Max(A, n-1));
        }

    }
}