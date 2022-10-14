namespace DSA_C.Arrays
{
    public class KadaneMaxSubArray
    {
        public void Start()
        {
            int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
            Console.WriteLine(MaxSubArray(nums));
        }

        public int MaxSubArray(int[] nums) 
        {
            int localMax=0, globalMax=int.MinValue;
            foreach(int num in nums)
            {
                localMax = Math.Max(localMax, localMax + num);
                globalMax = Math.Max(localMax, globalMax);
            }
            return globalMax;
        }
    }
}