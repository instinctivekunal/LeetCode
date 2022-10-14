using System.Linq;
namespace DSA_C.DP
{
    public class DeleteAndEarnProblem
    {
        // https://leetcode.com/problems/delete-and-earn/
        public void Start()
        {
            int[] nums = {3,4,2};        
            Console.WriteLine(DeleteAndEarn(nums));
        }

        int DeleteAndEarn(int[] nums) {
            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++)
            {
                if (count.ContainsKey(nums[i]))
                    count[nums[i]]++;
                else
                    count.Add(nums[i], 1);
            }

            int[] nos = nums.Distinct().ToArray();
            Array.Sort(nos);

            var (earn1, earn2, max) = (0, 0, 0);
            for (int i=0; i<nos.Length; i++)
            {
                max = nos[i] * count[nos[i]];
                var temp = earn2;
                if (i>0 && nos[i] == nos[i-1]+1) {
                    earn2 = Math.Max(earn1 + max, earn2);
                } else {
                    earn2 = earn2 + max;
                }
                earn1 = temp;
            }
            return earn2;
        }
    }
}
