namespace Search
{
    public class IntersectionArrayII
    {
        public void Start()
        {
            int[] nums1 = {1,2,2,1};
            int[] nums2 = {2,2};
            Console.WriteLine(string.Join("\t",Intersect(nums1, nums2)));
        }

         int[] Intersect(int[] nums1, int[] nums2) 
        {
            List<int> ans = new List<int>();
            Dictionary<int, int> nos = new Dictionary<int, int>();
            for(int i=0; i<nums1.Length; i++)
            {
                if(nos.ContainsKey(nums1[i]))
                    nos[nums1[i]] = nos[nums1[i]] + 1;
                else
                    nos.Add(nums1[i], 1);
            }
            for(int j=0; j<nums2.Length; j++)
            {
                if(nos.ContainsKey(nums2[j]) && nos[nums2[j]] > 0)
                {
                    ans.Add(nums2[j]);
                    nos[nums2[j]] = nos[nums2[j]] - 1;
                }
            }
            return ans.ToArray();
        }
    }
}