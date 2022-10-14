namespace Search
{
    public class ThreeSumClosestProblem

    {
        public void Start()
        {
            int[] nums = {4,0,5,-5,3,3,0,-4,-5};
            int target = -2;
            Console.WriteLine(ThreeSumClosest(nums, target));
        }

         int ThreeSumClosest(int[] nums, int target) 
        {
            var len = nums.Length;
            int closest = nums[0] + nums[1] + nums[len-1];            
            // Sort Array
            Array.Sort(nums);
            for(int i=0; i<len-2; i++)
            {
                int start = i+1, end = len-1;
                while(start<end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (sum > target)
                        end--;
                    else
                        start++;
                    if(Math.Abs(sum-target) < Math.Abs(closest-target))
                        closest = sum;
                }
            }
            return closest;
        }
    }
}