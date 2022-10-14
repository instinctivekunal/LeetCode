namespace DSA_C.Arrays
{
    public class ContainsDuplicateVals
    {
        public void Start()
        {
            int[] nums = {1,2,3,4};            
            Console.WriteLine(ContainsDuplicate(nums));
        }

        public bool ContainsDuplicate(int[] nums) 
        {
            // HashSet<int> inList = new HashSet<int>();
            // foreach(int num in nums)
            //     if (inList.Contains(num)) return true;
            //     else
            //         inList.Add(num);
            // return false;

            Dictionary<int, int> inList = new Dictionary<int, int>();
            foreach(int num in nums)
                if (inList.ContainsKey(num)) return true;
                else
                    inList.Add(num, 1);
            return false;
        }
    }
}