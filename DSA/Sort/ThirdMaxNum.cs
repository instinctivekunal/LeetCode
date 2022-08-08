using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class ThirdMaxNum
    {
        public static void Start()
        {
            int[] nums = {1,2,-2147483648};
            Console.WriteLine(ThirdMax(nums));
        }

        static int ThirdMax(int[] nums) 
        {
            long m1=long.MinValue, m2=long.MinValue, m3=long.MinValue;
            foreach(int n in nums)
            {
                if (n == m1 || n == m2 || n == m3) continue;
                if (n>=m1)
                {
                    m3=m2;
                    m2=m1;
                    m1=n;
                }
                else if (n >= m2)
                {
                    m3=m2;
                    m2=n;
                }
                else if (n >= m3)
                    m3=n;
            }
            return m3 == long.MinValue ? (int)m1 : (int)m3;        
        }
    }
}