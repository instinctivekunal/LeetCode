using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class KIntegerMinSum
    {
        public static void Start()
        {
            int[] arr = {53,41,90,33,84,26,50,32,63,47,66,43,29,88,71,28,83};
            int k = 76;
            Console.WriteLine(MinimalKSum(arr, k));
        }

        static long MinimalKSum(int[] nums, int k) 
        {
            long n=k;
            long sum = n*(n+1)/2;
            Array.Sort(nums);            
            HashSet<int> inList = new HashSet<int>();
            foreach(int num in nums)
            {
                if(num>n) break;
                if(inList.Add(num))
                {
                    n++;
                    sum -= num;
                    sum +=n;
                }
            }
            return sum;                    
        }
        
        // TLE
        static long MinimalKSum1(int[] nums, int k) 
        {
            HashSet<int> inList = new HashSet<int>();
            for(int i=0; i<nums.Length; i++)
            {
                inList.Add(nums[i]);
            }
            Console.WriteLine(string.Join(",", inList));
            int n=inList.Max()+1+k;
            long min=0;
            for (int i=1; i<=n; i++)
            {
                if(!inList.Contains(i))
                {                    
                    min+=i;
                    Console.WriteLine("S->{0}..{1}..{2}",i, k, min);
                    if (--k == 0)
                        break;
                    Console.WriteLine("E->{0}..{1}..{2}",i, k, min);
                }
            }
            return min;                    
        }
    }
}