namespace DSA_C.Sort
{
    public class MaxProduct2No
    {
        public void Start()
        {
            int[] nums = {3,4,5,2};
            Console.WriteLine(MaxProduct(nums));
        }

         int MaxProduct(int[] nums) 
        {
            Array.Sort(nums);
            return (nums[^1]-1) * (nums[^2]-1);
        }
    }
}