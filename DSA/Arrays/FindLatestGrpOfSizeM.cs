namespace DSA_C.Arrays
{
    public class FindLatestGrpOfSizeM
    {
        // https://leetcode.com/problems/find-latest-group-of-size-m/
        public void Start()
        {
            int[] nums = {3,5,1,2,4};
            int m = 2;
            Console.WriteLine(FindLatestStep(nums, m));
        }

        int FindLatestStep(int[] arr, int m) {
            int res = -1, n = arr.Length;
            int[] length = new int[n + 2], count = new int[n + 1];
            for (int i = 0; i < n; ++i) {
                int a = arr[i], left = length[a - 1], right = length[a + 1];
                length[a] = length[a - left] = length[a + right] = left + right + 1;
                count[left]--;
                count[right]--;
                count[length[a]]++;
                if (count[m] > 0)
                    res = i + 1;
            }
            return res;
        }
    }
}