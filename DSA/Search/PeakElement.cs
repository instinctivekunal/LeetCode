namespace Search
{
    public class PeakElement
    {
        public void Start()
        {
            int[] arr = {1,2,1,3,5,6,4};
            Console.WriteLine(FindPeakElement(arr));
        }

         int FindPeakElement(int[] nums) 
        {
            int start=0, end=nums.Length-1, mid=0;
            while(start<end)
            {
                mid = start+(end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (nums[mid] > nums[mid+1])
                    end = mid;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return start;
        }
    }
}