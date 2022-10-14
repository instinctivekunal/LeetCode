namespace DSA_C.Arrays
{
    // https://leetcode.com/problems/container-with-most-water/
    public class ContainerMostWater
    {
        public void Start()
        {
            int[] nums = {1,8,6,2,5,4,8,3,7};
            Console.WriteLine(MaxArea(nums));
        }

        // 2 pointer approach
        public int MaxArea(int[] height) {
            int l = 0, r = height.Length-1;
            int maxArea=0;
            while (l < r)
            {
                int width = r-l;
                maxArea = Math.Max(maxArea, Math.Min(height[l], height[r]) * width);
                if (height[l] <= height[r])
                    l++;
                else
                    r--;
            }
            return maxArea;
        }
    }
}