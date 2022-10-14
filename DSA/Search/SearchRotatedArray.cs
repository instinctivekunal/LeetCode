namespace Search
{
    public class SearchRotatedArray
    {
        public void Start()
        {
            int[] nums = {4,5,6,7,0,1,2};
            int target = 6;
            Console.WriteLine(Search(nums, target));
        }


         int Search(int[] nums, int target) 
        {
            int start = 0, end = nums.Length -1, mid =0;
            while (start<=end)            
            {
                if (nums[start] == target) return start;
                else if (nums[end] == target) return end;
                
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (nums[mid]==target)
                    return mid;

                if (target>nums[mid] && target<nums[end])
                    start=mid+1;
                else if(target<nums[mid] && target>nums[start])
                    end=mid-1;
                else{
                    start++;
                    end--;
                }
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return -1;
        }

         int Search1(int[] nums, int target) 
        {
            if(nums.Length == 1)
            {
                return nums[0] == target ? 0 : -1;
            }
            int peak = PeakIndexInMountainArray(nums);
            int firstHalf = OrderAgnosticBS(nums, target, 0, peak);
            if (firstHalf != -1)
                return firstHalf;
            return OrderAgnosticBS(nums, target, peak+1, nums.Length-1);                        
        }

         int PeakIndexInMountainArray(int[] arr) 
        {
            int start=0, end = arr.Length-1, mid=0;
            while(start<end)
            {
                mid = start + (end-start)/2;
                if (arr[mid] > arr[mid-1] && arr[mid] > arr[mid+1])
                    return mid;
                if (arr[mid] > arr[mid+1])
                    end=mid;
                else
                    start=mid+1;
            }
            return start;
        }

         int OrderAgnosticBS(int[] nums, int target, int start, int end)
        {
            bool isAsc = nums[start]<nums[end];
            while(start<=end)
            {
                int mid = start + (end-start)/2;
                if (nums[mid] == target)
                    return mid;
                if(isAsc)
                {
                    if(target < nums[mid])
                        end=mid-1;
                    else
                        start=mid+1;
                }
                else
                {
                    if(target > nums[mid])
                        end=mid-1;
                    else
                        start=mid+1;
                }
            }
            return -1;
        }
    }
}