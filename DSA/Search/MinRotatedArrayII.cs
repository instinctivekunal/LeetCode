namespace Search
{
    public class MinRotatedArrayII
    {
        public void Start()
        {
            int[] nums = {2,2,2,0,1};
            Console.WriteLine(FindMin(nums));
        }

         int FindMin(int[] nums) 
        {
            int start = 0, end = nums.Length -1, mid =0;
            while (start<end)            
            {
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if(nums[mid]>nums[end])
                    start=mid+1;
                else if(nums[mid]<nums[end])
                    end=mid;
                else
                    end--;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return nums[start];
        }
    }
}