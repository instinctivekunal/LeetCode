namespace DSA_C.Arrays
{
    public class PrdArrayExceptSelf
    {
        public void Start()
        {
            int[] nums = {1,2,3,4,5};
            Console.WriteLine(string.Join(",", ProductExceptSelf2(nums)));
        }

         int[] ProductExceptSelf2(int[] nums) 
        {
            int n= nums.Length;
            int[] result = new int[n];
            int[] prefix = new int[n];
            int[] suffix = new int[n];
            prefix[0] = 1;
            suffix[n-1] = 1;
            for(int i=1; i<n; i++)
                prefix[i] = prefix[i-1] * nums[i-1];
            for(int i=n-2; i>=0; i--)
                suffix[i] = suffix[i+1] * nums[i+1];
            for(int i=0; i<n; i++)
                result[i] = prefix[i] * suffix[i];
            return result;
        }

         int[] ProductExceptSelf1(int[] nums) 
        {
            var result = new int[nums.Length];    
            var prefix = 1;
            var suffix = 1;
            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            {
                Console.WriteLine("S->{0}..{1}..{2}..{3}..{4}..{5}", i,j,prefix, suffix, result[i], result[j]);
                
                if (i <= j)
                    result[i] = result[j] = 1;

                result[i] *= prefix;
                result[j] *= suffix;

                prefix *= nums[i];
                suffix *= nums[j];
                Console.WriteLine("E->{0}..{1}..{2}..{3}..{4}..{5}", i,j,prefix, suffix, result[i], result[j]);
                Console.WriteLine(string.Join(",", result));
            }            
            return result;       
        }

         int[] ProductExceptSelf(int[] nums) 
        {
            int[] ans = new int[nums.Length];
            int i=0, j=1, prd=1;
            while (i<nums.Length)
            {
                if (i!=j && j<nums.Length)
                {
                    prd *= nums[j];
                }
                j++;
                if (j == nums.Length)
                {
                    ans[i] = prd;
                    j=0;
                    i++;
                    prd=1;
                }
            }
            return ans;        
        }
    }
}