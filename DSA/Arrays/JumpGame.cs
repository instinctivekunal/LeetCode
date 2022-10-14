namespace DSA_C.Arrays
{
    public class JumpGame
    {
        public void Start()
        {
            int[] nums = {2,3,1,1,1};
            Console.WriteLine(string.Join(",", CanJump(nums)));
        }

         bool CanJump(int[] nums) 
        {
            int jump = nums.Length-1;            
            for (int i=nums.Length-2; i>=0; i--)
            {
                //Console.WriteLine("S->{0}..{1}..{2}",jump, i, nums[i]);
                if (i+nums[i] >= jump)
                    jump = i;
                //Console.WriteLine("E->{0}..{1}..{2}",jump, i, nums[i]);
            }
            return jump == 0;
        }
    }
}