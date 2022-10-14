namespace Search
{
    public class ThreeSumProblem
    {
        public void Start()
        {
            int[] nums = {0,0,0};
            var ans = ThreeSum(nums);
        }

         IList<IList<int>> ThreeSum(int[] nums) 
        {
            int target = 0;
            var len = nums.Length;
            // Sort Array
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int first = 0; first < len; first++)
            {
                // If the current value is the same as the one before, skip it
                if (first > 0 && nums[first - 1] == nums[first]) continue;

                int second = first + 1, third = len - 1;
                while (second < third)
                {
                    int sum = nums[first] + nums[second] + nums[third];
                    if (sum > target)
                        third--;
                    else if (sum < target)
                        second++;
                    else // if(sum==target)
                    {
                        result.Add(new List<int>() { nums[first], nums[second++], nums[third--]});                            
                        while (second < third && nums[second - 1] == nums[second]) second++;
                    }
                }               
            }
            return result;
        }
    }
}