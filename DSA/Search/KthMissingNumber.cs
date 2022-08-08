using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class KthMissingNumber
    {
        public static void Start()
        {
            int[] arr = {2,3,4,7,11};
            int k = 5;
            Console.WriteLine(FindKthPositive(arr, k));
        }

        static int FindKthPositive(int[] arr, int k) 
        {
            HashSet<int> inList = new HashSet<int>();
            for(int i=0; i<arr.Length; i++)
            {
                inList.Add(arr[i]);
            }
            Console.WriteLine(string.Join(",", inList));
            int n=arr[arr.Length-1];
            for (int i=1; i<=n; i++)
            {
                if(!inList.Contains(i))
                {                    
                    Console.WriteLine("S->{0}..{1}",i, k);
                    if (--k == 0)
                        return i;
                }
            }
            return n+k;
        }
    }
}