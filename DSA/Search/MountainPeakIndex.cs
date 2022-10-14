namespace Search
{
    public class MountainPeakIndex
    {
        public void Start()
        {
            int[] arr = {1,3,5,6,10,9,7,4,2};
            Console.WriteLine(PeakIndexInMountainArray(arr));
        }

        int PeakIndexInMountainArray(int[] arr) 
        {
            int start=0, end = arr.Length-1, mid=0;
            while(start<end)
            {
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (arr[mid] > arr[mid-1] && arr[mid] > arr[mid+1])
                    return mid;
                if (arr[mid] > arr[mid+1])
                    end=mid;
                else
                    start=mid+1;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return start;
        }
    }
}