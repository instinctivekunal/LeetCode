namespace DSA_C.Arrays
{
    public class MoveZerosProblem
    {
        public void Start()
        {
            int[] nums = {0,1,0,3,12};
            MoveZeroes(nums);
        }

        void MoveZeroes(int[] nums) {
            int i=0,j=0;
            while(i < nums.Length)
            {
                if (nums[i] != 0)
                    nums[j++] = nums[i];
                i++;
            }
            while (j<nums.Length)
                nums[j++] = 0;
        }

        void MoveZeroesI(int[] nums) {
            int i=0, j=0;            
            while(j < nums.Length && i < nums.Length)
            {
                if(Math.Abs(nums[i]) > 0)
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j++;
                }  
                i++;
            }        
        }

        void MoveZeroes1(int[] nums) {
            int[] ans = new int[nums.Length];
            int i=0;
            foreach(int num in nums)
            {
                if (num != 0)
                    ans[i++] = num;
            }
            nums = ans;
        }
    }
}