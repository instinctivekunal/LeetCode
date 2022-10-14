namespace DSA_C.Recursion
{
    public class CombinationSeriesI
    {
        public void Start()
        {
            int k = 2;
            int target = 4;
            var ans = CombinationSum(k, target);
            foreach(List<int> row in ans)
                Console.WriteLine(string.Join(" ", row));
        }

         IList<IList<int>> CombinationSum(int k, int n) {
            IList<IList<int>> ans = new List<IList<int>> ();
            CombinationSum(k, n, 1, new List<int>(), ans);
            return ans;
        }

        // https://leetcode.com/problems/combinations/
         void CombinationSum(int k, int target, int idx, List<int> current, IList<IList<int>> ans)
        {
            // Base Conditions
            // Append the target element at the end.
            if (current.Count == k)
            {
                ans.Add(new List<int>(current));
                return;
            }

            // Loops through the array
            for(int o = idx; o <= target; o++)
            {
                current.Add(o);
                CombinationSum(k, target, o + 1, current, ans); //k+1 bcoz we can't resue same elements
                current.RemoveAt(current.Count-1); // Backtracking
            }
        }

        // https://leetcode.com/problems/combination-sum-iii/
         void CombinationSumIII(int k, int target, int idx, List<int> current, IList<IList<int>> ans)
        {
            // Base Conditions
            // Append the target element at the end.
            if (target == 0 && current.Count == k)
            {
                ans.Add(new List<int>(current));
                return;
            }

            // Loops through the array
            for(int o = idx; o <= 9; o++)
            {
                if (o > target) continue; 
                current.Add(o);
                CombinationSumIII(k, target-o, o + 1, current, ans); //k+1 bcoz we can't resue same elements
                current.RemoveAt(current.Count-1); // Backtracking
            }
        }
    }
}