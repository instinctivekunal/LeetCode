namespace DSA_C.Arrays
{
    public class SingleNoProblem
    {
        // https://leetcode.com/problems/single-number/
        public void Start()
        {
            int[] nums = {1,2,1,3,2,5};
            // Console.WriteLine(SingleNumber(nums));
            Console.WriteLine(string.Join("\t", SingleNumberIII(nums)));
        }

        int SingleNumber(int[] nums) {
            Array.Sort(nums);
            for (int i=0; i<nums.Length-1; i=i+2)
                if (nums[i] != nums[i+1])
                    return nums[i];
            return nums[nums.Length-1];
        }

        int SingleNumberII(int[] nums) {
            Array.Sort(nums);
            for (int i=0; i<nums.Length-1; i=i+3)
                if (nums[i] != nums[i+1] && nums[i] != nums[i+2])
                    return nums[i];
            return nums[nums.Length-1];
        }

        int[] SingleNumberIII(int[] nums) {
            var set = new HashSet<int>();
            foreach (var num in nums) 
            {
                if (!set.Add(num))
                {
                set.Remove(num);
                }
            }        
            return set.ToArray();
        }
    }
}