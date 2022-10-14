namespace DSA_C.Sort
{
    public class SetMismatch
    {
        public void Start()
        {
            int[] nums = {4,3,2,7,8,5,3,1};
            Console.WriteLine(string.Join(",", FindErrorNums(nums)));
        }

         int[] FindErrorNums(int[] nums) 
        {
            int[] ans = new int[2];
            CyclicSort(nums);
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i]-1 != i) 
                {
                    ans[0] = nums[i];
                    ans[1] = i+1;
                }
            }
            return ans;        
        }

         void CyclicSort(int[] arr)
        {
            int i=0;
            while(i<arr.Length)
            {
                int correct = arr[i] - 1;
                if (arr[i] != arr[correct])
                    Swap(arr, i,correct);
                else
                    i++;
            }

        }

         void Swap(int[] arr, int f, int s)
        {
            int t = arr[f];
            arr[f] = arr[s];
            arr[s] = t;
        }
    }
}