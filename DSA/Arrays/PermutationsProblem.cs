namespace DSA_C.Arrays
{
    public class PermutationsProblem
    {
        // https://leetcode.com/problems/permutations/
        public void Start()
        {
            int[] nums = {1,2,3};
            var ans = Permute(nums);
            foreach(List<int> n in ans)
                Console.WriteLine(string.Join(" ", n));
            Console.WriteLine("Permutations Unique: ");
            int[] nums1 = {1,1,2};
            var ans1 = PermuteUnique(nums1);
            foreach(List<int> n in ans1)
                Console.WriteLine(string.Join(" ", n));
        }

        IList<IList<int>> Permute(int[] nums) {
            var result = new List<IList<int>>();
            Permutations(result, nums, 0);
            return result;
        }

        void Permutations(List<IList<int>> result, int[] nums, int idx)
        {
            result.Add(nums.ToList());
            for (int i=idx; i<nums.Length; i++) {
                for (int j=i+1; j<nums.Length; j++) {
                    Swap(nums, i, j);
                    Permutations(result, nums, i+1);
                    Swap(nums, j, i);
                }
            }
        }

        // https://leetcode.com/problems/permutations-ii/

        IList<IList<int>> PermuteUnique(int[] nums) {
            var result = new List<IList<int>>();
            PermutationsUnique(result, nums, 0);
            return result;
        }

        void PermutationsUnique(List<IList<int>> result, int[] nums, int idx)
        {
            if (idx == nums.Length) {
                result.Add(nums.ToList());
                return;
            }
            HashSet<int> visited = new HashSet<int>();
            for (int i=idx; i<nums.Length; i++) {
                if (visited.Add(nums[i])) {
                    Swap(nums, i, idx);
                    PermutationsUnique(result, nums, idx+1);
                    Swap(nums, i, idx);
                }
            }
        }
        void Swap(int[] nums, int f, int s)
        {
            int temp = nums[f];
            nums[f] = nums[s];
            nums[s] = temp;
        }

        void UpdateResult(List<IList<int>> result, int[] nums)
        {
            var exist = false;
            foreach(List<int> ans in result)
                if(ans.SequenceEqual(nums.ToList())) {
                    exist = true;
                }
            if (!exist)
                result.Add(nums.ToList());
        }

        
    }
}