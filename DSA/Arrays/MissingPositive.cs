using System.Collections;

namespace DSA_C.Arrays
{
    public class MissingPositive
    {
        public void Start()
        {
            int[] nums = {1,2,0};
            Console.WriteLine(string.Join(",", FirstMissingPositive(nums)));
        }

         int FirstMissingPositive(int[] nums) 
        {
            int n=0;
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] > 0)
                    nums[n++] = nums[i];
            }
            Console.WriteLine(n);
            Console.WriteLine(string.Join(",", nums));
            for (int i=0; i<n; i++)
            {
                int j = Math.Abs(nums[i]);
                if (j <= n)
                {
                    if(nums[j-1] > 0)
                        nums[j-1] = -nums[j-1];
                }           
            }
            Console.WriteLine(string.Join(",", nums));
            for (int i=0; i<n; i++)
            {
                if(nums[i] > 0)
                    return i+1;
            }
            Console.WriteLine(string.Join(",", nums));
            return n+1;
        }

         int FirstMissingPositive1(int[] nums) 
        {
            HashSet<int> inList = new HashSet<int>();
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i]<0)
                    continue;
                inList.Add(nums[i]);
            }
            if (inList.Count==0)
                return 1;
            for (int i=1; i<=nums.Length+1; i++)
            {
                if(!inList.Contains(i))
                    return i;
            }
            return nums.Length;
        }

         int FirstMissingPositive2(int[] nums) 
        {
            var inList = new BitArray(int.MaxValue);
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i]<=0)
                    continue;
                inList[nums[i]-1] = true;
            }
            for (int i=0; i<nums.Length; i++)
            {
                if(inList[i] == false)
                    return i+1;
            }
            return 1;
        }
    }
}