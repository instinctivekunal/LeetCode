namespace DSA_C.Arrays
{
    public class TriangularSumProblem
    {
        public void Start()
        {
            int[] nums = {5};
            Console.WriteLine(TriangularSum(nums));
        }

        int TriangularSum(int[] nums) {
            int n = nums.Length;
            while(--n > 0)
            {
                for (int i=0; i<nums.Length-1; i++)
                    nums[i] = (nums[i] + nums[i+1]) % 10;
                Console.WriteLine(string.Join("\t", nums.ToList()));
            }
            return nums[0];
        }

    }
}