namespace DSA_C.Arrays
{
    // https://leetcode.com/problems/trapping-rain-water/
    public class TrappingRainwater
    {
        public void Start()
        {
            int[] nums = {0,1,0,2,1,0,1,3,2,1,2,1};
            Console.WriteLine(Trap(nums));
        }

        // 2 pointer approach
        public int Trap(int[] height) {
            int n = height.Length;
            int l = 0, r = n-1, lm = 0, rm = 0, ans = 0;
            while (l <= r)
            {
                if (height[l] <= height[r]) {
                    if (height[l] > lm) lm = height[l];
                    else ans += lm-height[l];
                    l++;
                }
                else {
                    if (height[r] > rm) rm=height[r];
                    else ans += rm-height[r];
                    r--;
                }
            }
            return ans;
        }

        // Prefix Sum approach
        public int Trap1(int[] height) {
            int n = height.Length;
            int[] prefix = new int[n];
            int[] suffix = new int[n];
            prefix[0] = height[0];
            for (int i = 1; i < n; i++) {
                prefix[i] = Math.Max(prefix[i - 1], height[i]);
            }
            suffix[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--) {
                suffix[i] = Math.Max(suffix[i + 1], height[i]);
            }
            int waterTrapped = 0;
            for (int i = 0; i < n; i++) {
                waterTrapped += Math.Min(prefix[i], suffix[i]) - height[i];
            }
            return waterTrapped;
        }


    }
}