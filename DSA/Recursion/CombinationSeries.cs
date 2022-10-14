
namespace DSA_C.Recursion
{
    public class CombinationSeries
    {
        public void Start()
        {
            int[] nums = {1,2,3,4};
            int target = 4;
            var ans = CombinationSum(nums, target);
            foreach(List<int> row in ans)
                Console.WriteLine(string.Join(" ", row));
        }

         IList<IList<int>> CombinationSum(int[] candidates, int target) {
            IList<IList<int>> ans = new List<IList<int>> ();
            Array.Sort(candidates);
            CombinationSumIV(candidates, target, 0, new List<int>(), ans);
            return ans;
        }

        // https://leetcode.com/problems/combination-sum-iv/
         void CombinationSumIV(int[] arr, int target, int idx, List<int> current, IList<IList<int>> ans)
        {
            // Base Conditions
            // Append the target element at the end.
            if (target == 0)
            {
                ans.Add(new List<int>(current));
                return;
            }

            // Loops through the array
            for(int k = idx; k < arr.Length; k++)
            {
                if (arr[k] > target) continue;
                current.Add(arr[k]);
                CombinationSumIV(arr, target-arr[k], k, current, ans);
                current.RemoveAt(current.Count-1); // Backtracking
            }            
        }

        // https://leetcode.com/problems/combination-sum-ii/
         void CombinationSumII(int[] arr, int target, int idx, List<int> current, IList<IList<int>> ans)
        {
            // Base Conditions
            // Append the target element at the end.
            if (target == 0)
            {
                ans.Add(new List<int>(current));
                return;
            }

            // Loops through the array
            for(int k = idx; k < arr.Length; k++)
            {
                if (k > idx && arr[k] == arr[k-1]) continue; // New logic to skip duplicate elements
                if (arr[k] > target) continue; 
                current.Add(arr[k]);
                CombinationSumII(arr, target-arr[k], k + 1, current, ans); //k+1 bcoz we can't resue same elements
                current.RemoveAt(current.Count-1); // Backtracking
            }
        }

        // https://leetcode.com/problems/combination-sum/
         void CombinationSumI(int[] arr, int target, int idx, List<int> current, IList<IList<int>> ans)
        {
            // Base Conditions
            // Append the target element at the end.
            if (target == 0)
            {
                ans.Add(new List<int>(current));
                return;
            }

            // Loops through the array
            for(int k = idx; k < arr.Length; k++)
            {
                if (arr[k] > target) continue;
                current.Add(arr[k]);
                CombinationSumI(arr, target-arr[k], k, current, ans);
                current.RemoveAt(current.Count-1); // Backtracking
            }            
        }
    }
}