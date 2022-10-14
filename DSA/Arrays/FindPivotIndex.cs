namespace DSA_C.Arrays
{
    public class FindPivotIndex
    {
        public void Start()
        {
            int[] nums = {1,2,3};
            Console.WriteLine(PivotIndex(nums));
        }

        int PivotIndex(int[] nums) {
            int n = nums.Length;
            int[] fs = new int[n]; // Forward Sum
            int[] bs = new int[n]; // Backward Sum
            fs[0] = nums[0];
            bs[n-1] = nums[n-1];
            for (int i=1; i<n; i++)
                fs[i] = fs[i-1] + nums[i];
            for (int i=n-2; i>=0; i--)
                bs[i] = bs[i+1] + nums[i];
            for (int i=0; i<n; i++)
            {
                if (fs[i] == bs[i])
                    return i;
            }
            return -1;
        }
    }
}