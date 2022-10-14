namespace DSA_C.Arrays
{
    public class SubsetsII
    {
        public void Start()
        {
            int[] nums = {1,2,2};
            var ans = SubsetsWithoutDup(nums);
        }

        public IList<IList<int>> SubsetsWithoutDup(int[] nums) {
            Array.Sort(nums);
            var outer = new List<IList<int>>();
            outer.Add(new List<int>());
            int start=0, end=0;
            for (int j=0; j<nums.Length; j++)
            {
                start = 0;
                if (j>0 && nums[j] == nums[j-1])
                    start = end+1;                
                int size = outer.Count;
                end = size-1;
                for (int i=start; i<size; i++)
                {
                    var subList = new List<int>(outer[i]);
                    subList.Add(nums[j]);
                    outer.Add(subList);
                }
            }
            return outer;
        }
    }
}