namespace DSA_C.Recursion
{
    public class BinarySearchRecursion
    {
        public void Start()
        {
            int[] nums = {1, 4, 3, -5, -4, 8, 6};
            Console.WriteLine(Search(nums, 9));
        }

         int Search(int[] nums, int target) 
        {
            return BinarySearch(nums, target, 0, nums.Length-1);
        }

         int BinarySearch(int[] A, int target, int start, int end)
        {
            while(start<=end)
            {
                int mid = start + (end-start)/2;
                if (A[mid] == target)
                    return mid;
                if (A[mid] < target)
                    return BinarySearch(A, target, mid+1, end);
                else
                    return BinarySearch(A, target, start, mid-1);
            }
            return -1;
        }
    }
}