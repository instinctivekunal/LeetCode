namespace DSA_C.Arrays
{
    public class NextPermutationProblem
    {
        public void Start()
        {
            int[] nums = {5,1,1};
            NextPermutation(nums);
            int[] nums1 = {5,1,1};
            nextPermutation(nums1);
        }

        public void nextPermutation(int[] A) {
            if(A == null || A.Length <= 1) return;
            int i = A.Length - 2;
            while(i >= 0 && A[i] >= A[i + 1]) i--; // Find 1st id i that breaks descending order
            if(i >= 0) {                           // If not entirely descending
                int j = A.Length - 1;              // Start from the end
                while(A[j] <= A[i]) j--;           // Find rightmost first larger id j
                Swap(A, i, j);                     // Switch i and j
            }
            Reverse(A, i + 1, A.Length - 1);       // Reverse the descending sequence
        }

        void NextPermutation(int[] nums) {
            if (nums == null || nums.Length <= 1) return;
            // Initialize index to second last num
            int idx = nums.Length-2;
            // Find index of peak value
            while (idx >= 0 && nums[idx] >= nums[idx+1])
                idx--;
            
            if (idx >= 0)
            {
                int i = nums.Length-1;
                while (i>=0 && nums[i] <= nums[idx])
                    i--;
                Swap(nums, idx, i);
            }
            Reverse(nums, idx+1, nums.Length-1);
        }

        void Reverse(int[] A, int start, int end)
        {
            while (start < end)
                Swap(A, start++, end--);
        }

        void Swap(int[] A, int first, int second)
        {
            int temp = A[first];
            A[first] = A[second];
            A[second] = temp;
        }
    }
}