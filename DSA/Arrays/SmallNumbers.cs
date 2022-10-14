namespace DSA_C.Arrays
{
    public class SmallNumbers
    {
        public void Start()
        {
            int[] nums = {8,1,2,2,3};
            Console.WriteLine(string.Join(",", SmallerNumbersThanCurrent(nums)));
        }

         int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int n = nums.Length;
            int[] ans = new int[n];
            for (int i=0; i<n; i++)
            {
                ans[i] = 0;
                for (int j=0; j<n; j++)
                {
                    if(nums[j] < nums[i])
                        ans[i]++;
                }
            }
            return ans;
        }
    }
}