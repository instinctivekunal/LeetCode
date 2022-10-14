namespace DSA_C.Sort
{
    public class ArrEqlByReversingSubArray
    {
        public void Start()
        {
            int[] nums = {1,2,3,4};
            int[] arr = {2,4,1,3};
            Console.WriteLine(CanBeEqual(nums, arr));
        }

         bool CanBeEqual(int[] target, int[] arr) 
        {
            Array.Sort(target);
            Array.Sort(arr);
            return target.SequenceEqual(arr);
        }
    }
}