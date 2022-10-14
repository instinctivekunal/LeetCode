namespace DSA_C.Sort
{
    public class DisappearedNumsInArray
    {
        public void Start()
        {
            int[] nums = {4,3,2,7,8,2,3,1};
            Console.WriteLine(string.Join(",", FindDisappearedNumbers(nums)));
        }

         IList<int> FindDisappearedNumbers(int[] nums) 
        {
            IList<int> ans = new List<int>();
            CyclicSort(nums);
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i]-1 != i) ans.Add(i+1);
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