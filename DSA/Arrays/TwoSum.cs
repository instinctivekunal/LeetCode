namespace DSA_C.Arrays
{
    public class TwoSum
    {
        public void Start()
        {
            int[] nums = {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1};
            int target = 11;
            Console.WriteLine(string.Join(",", TwoSumMethod(nums, target)));
        }

        int[] TwoSumMethod(int[] nums, int target) 
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                if (data.ContainsKey(target - nums[i]))
                    return new int[]{data[target - nums[i]], i};
                else
                    data.TryAdd(nums[i], i);
            }
            return new int[]{0,0};
        }

        int[] TwoSumMethod1(int[] nums, int target) 
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            int[] ans = new int[2];
            for(int i=0; i<nums.Length; i++)
            {
                if (data.ContainsValue(target - nums[i]))
                {
                    ans[0] = data.First(x => x.Value == (target - nums[i])).Key;
                    ans[1] = i;
                    break;
                }
                data.Add(i, nums[i]);                
            }
            return ans;
        }
    }
}