namespace DSA_C.Arrays
{
    public class IdenticalPairs
    {
        public void Start()
        {
            int[] nums = {1,2,3,1,1,3};
            Console.WriteLine(NumIdenticalPairs(nums));
        }

         int NumIdenticalPairs(int[] nums) 
        {  
            // Dictionary<int, int> data = new Dictionary<int, int>();
            // foreach(int num in nums)        
            // {
            //     if(data.ContainsKey(num))
            //         data[num] +=1;
            //     else
            //         data[num] = 1;
            // }
            // int pair = 0;
            // foreach(var val in data.Values)
            // {
            //     pair += ((val*(val-1))/2);
            // }
            // return pair;
            int res = 0;
            int[] count = new int[101];
            foreach(int n in nums)
            {
                res += count[n]++;
            }
            return res;
        }
    }
}