namespace DSA_C.Arrays
{
    public class FindAllDuplicateNums
    {
        public void Start()
        {
            int[] nums = {1,1,2};
            Console.WriteLine(string.Join(",", FindDuplicates(nums)));
        }

           IList<int> FindDuplicates1(int[] nums) {
            Array.Sort(nums);
            IList<int> ans = new List<int>();
            for(int i=0; i<nums.Length-1; i++)
            {   
                if(nums[i] == nums[i+1])
                    ans.Add(nums[i]);
            }            
            return ans;
        }

         IList<int> FindDuplicates(int[] nums) 
        {
            IList<int> ans=new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                int n = Math.Abs(nums[i]);
                if(nums[n-1] > 0)
                    nums[n-1] *= -1;
                else
                    ans.Add(n);
            }
            return ans;
        }
        
    }
}
