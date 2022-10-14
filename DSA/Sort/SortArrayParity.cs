namespace DSA_C.Sort
{
    public class SortArrayParity
    {
        public void Start()
        {
            int[] nums = {0};
            Console.WriteLine(string.Join(",", SortArrayByParity(nums)));
        }

         int[] SortArrayByParity(int[] nums) {
            int[] ans = new int[nums.Length];
            int i=0, j=nums.Length-1;
            foreach(int n in nums)
            {
                if(n%2 == 0)
                    ans[i++] = n;
                else
                    ans[j--] = n;
            }
            return ans;
        }
    }
}