namespace DSA_C.Sort
{
    public class LargestPerimeterTriangle
    {
        public void Start()
        {
            int[] nums = {1,2,1};
            Console.WriteLine(LargestPerimeter(nums));
        }

         int LargestPerimeter(int[] nums) 
        {
            Array.Sort(nums);
            for(int i=nums.Length-1; i>1; i--)
            {
                if(nums[i] < nums[i-1] + nums[i-2])
                    return nums[i] + nums[i-1] + nums[i-2];
            }
            return 0;
        }
    }
}