namespace DSA_C.Arrays
{
    public class PlusOneProblem
    {
        // https://leetcode.com/problems/plus-one/
        public void Start()
        {
            int[] nums = {2,3,4};        
            Console.WriteLine(string.Join(" ", PlusOne(nums)));
        }

        int[] PlusOne(int[] digits) {
            int n = digits.Length;
            List<int> ans = digits.ToList();
            for (int i=n-1; i>=0; i--)
            {
                ans[i]++;
                if (ans[i] == 10) {
                    ans[i] = 0;
                    if (i == 0)
                        ans.Insert(0, 1);
                } else break;
            }
            return ans.ToArray();
        }
    }
}