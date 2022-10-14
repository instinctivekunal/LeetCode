namespace Search
{
    public class CheckDoubleExist
    {
        public void Start()
        {
            int[] arr = {-2,0,10,4,6,-8};
            Console.WriteLine(CheckIfExist(arr));
        }

         bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            for(int i=0; i<arr.Length; i++)
            {
                int idx = BinarySearch(arr, arr[i]*2);
                if(idx!=-1 && idx!=i)
                    return true;
            }                        
            return false;
        }

         int BinarySearch(int[] nums, int target)
        {
            int mid=0;
            int start=0, end=nums.Length-1;
            while(start<=end)
            {
                mid = start + (end-start)/2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    start=mid+1;
                else
                    end=mid-1;
            }
            return -1;
        }

         bool CheckIfExist1(int[] arr)
        {
            HashSet<int> data = new HashSet<int>();
            for(int i=0; i<arr.Length; i++)
            {
                if (data.Contains(arr[i]*2) || (arr[i]%2==0 && data.Contains(arr[i]/2)))
                    return true;
                data.Add(arr[i]);
            }                        
            return false;
        }
    }
}