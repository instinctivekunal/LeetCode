namespace DSA_C.Sort
{
    public class MissingNum
    {
        public void Start()
        {
            int[] nums = {0,1};
            Console.WriteLine(MissingNumber(nums));
        }

         int MissingNumber(int[] nums) {
            Array.Sort(nums);
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != i) return i;
            }
            return nums.Length;
        }
    }
}