namespace DSA_C.Arrays
{
    public class BuildFromPermutation
    {
        public void Start()
        {
            int[] nums = {0,2,1,5,3,4};
            Console.WriteLine(string.Join(",", BuildArray(nums)));
        }
        
         int[] BuildArray(int[] nums) 
        {
            int[] ans = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }

    }
}