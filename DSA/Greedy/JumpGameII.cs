namespace DSA_C.Greedy
{
    public class JumpGameII
    {
        public void Start()
        {
            int[] nums = new int[] {2,3,1,1,4};
            Console.WriteLine(Jump(nums));
        }

         int Jump(int[] nums) 
        {
            int end = 0, maxJump = 0, jump = 0;
            for(int i=0; i<nums.Length-1; i++)
            {
                maxJump = Math.Max(maxJump, i+nums[i]);
                if (i==end)
                {
                    jump++;
                    end = maxJump;
                }
            }
            return jump;
        }
    }
}