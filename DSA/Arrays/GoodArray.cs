namespace DSA_C.Arrays
{
    public class GoodArray
    {
        public void Start()
        {
            int[] nums = {3,6};
            Console.WriteLine(IsGoodArray(nums));
        }

         bool IsGoodArray(int[] nums) 
        {
            if (nums==null || nums.Length==0)
                return true;
            if (nums.Length == 1)
                return nums[0] == 1;
            int res = nums[0];
            for (int i=1; i<nums.Length; i++)
            {
                res = GCD(nums[i], res);
                if (res==1)
                    return true;
            }
            return false;        
        }

         int GCD(int a, int b)
        {
            while (b!=0)
            {
                int t= b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }
}