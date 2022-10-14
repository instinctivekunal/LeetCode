using System.Text;

namespace DSA_C.Recursion
{
    public class PermutationSequence
    {
        // https://leetcode.com/problems/permutation-sequence/
        public void Start()
        {
            int n = 4;
            int k = 9;
            Console.WriteLine(GetPermutation(n, k));
        }

         string GetPermutation(int n, int k) {
            List<int> nums = new List<int>();
            int fact = 1;
            for (int i=1; i<=n; i++)
            {                
                nums.Add(i);
                if (i==n) break;
                fact *= i;
            }
            k--;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                // Get Current Index
                int idx = k/fact;
                sb.Append(nums[idx]);
                nums.RemoveAt(idx);                
                if (nums.Count == 0) break;
                // Calculate k & fact for next iteration
                k=k%fact;
                fact = fact/nums.Count;
            }
            return sb.ToString();
        }

         string GetPermutation1(int n, int k) {
            string up ="";
            // Creating the unprocessed string based on n
            for(int i=1; i<=n; i++)
                up += i;
            var list = Permutations("", up);
            list.Sort();
            return list[k-1];
        }

        List<string> Permutations(string p, string up)
        {
            if(up.Length == 0)
            {
                List<string> m = new List<string>();
                m.Add(p);
                return m;
            }

            char ch = up[0];
            List<string> ans = new List<string>();
            for(int i=0; i<=p.Length; i++)
            {
                string s = p.Substring(0, i);
                string e = p.Substring(i);
                ans.AddRange(Permutations(s+ch+e, up.Substring(1)));
            }
            return ans;
        }
    }
}