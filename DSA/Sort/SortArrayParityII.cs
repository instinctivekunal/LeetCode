namespace DSA_C.Sort
{
    public class SortArrayParityII
    {
        public void Start()
        {
            int[] nums = {4,2,5,7};
            Console.WriteLine(string.Join(",", SortArrayByParityIIInPlace(nums)));
        }

         int[] SortArrayByParityIIInPlace(int[] nums) {
            int n=nums.Length;
            int e=0, o=1;
            while(e<n && o<n)
            {
                while(e<n && nums[e]%2 == 0)
                    e+=2;
                while(o<n && nums[o]%2 == 1)
                    o+=2;
                if(e<n && o<n)
                {
                    //Swap elements
                    int tmp = nums[e];
                    nums[e] = nums[o];
                    nums[o] = tmp;
                }
            }
            return nums;
        }

         int[] SortArrayByParityII(int[] nums) {
            int[] ans = new int[nums.Length];
            int i=0, j=1;
            foreach(int n in nums)
            {
                if(n%2 == 0) {
                    ans[i] = n;
                    i+=2;
                }
                else {
                    ans[j] = n;
                    j+=2;
                }
            }
            return ans;
        }
    }
}