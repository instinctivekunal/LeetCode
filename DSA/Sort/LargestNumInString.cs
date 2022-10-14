using System.Text;

namespace DSA_C.Sort
{
    public class LargestNumInString
    {
        public void Start()
        {
            int[] nums = {4,3,2,7,8,2,3,1};
            Console.WriteLine(string.Join(",", LargestNumber(nums)));
        }

         string LargestNumber(int[] nums) 
        {
            Comparer<string> c = Comparer<string>.Default;
            Array.Sort<int>(nums, (a,b) => c.Compare(a.ToString() + b.ToString(), b.ToString() + a.ToString()));
            if (nums[nums.Length -1] == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            for(int i=nums.Length-1; i>=0; i--)
                sb.Append(nums[i]);
            return sb.ToString();
        }        
    }
}