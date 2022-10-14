namespace DSA_C.Sort
{
    public class MajorityElement
    {
        public void Start()
        {
            int[] nums = {3,2,3};
            Console.WriteLine(MajorityElem(nums));
        }

         int MajorityElem(int[] nums) 
        {
            Array.Sort(nums);
            return nums[nums.Length/2];
        }

         int MajorityElem1(int[] nums) 
        {
            Dictionary<int,int> set = new Dictionary<int,int>();
            for (int i=0; i<nums.Length; i++)        
            {
                if(set.ContainsKey(nums[i]))
                    set[nums[i]] += 1;
                else
                    set.Add(nums[i], 1);
            }
            return set.OrderByDescending(x=>x.Value).First().Key;
        }
    }
}