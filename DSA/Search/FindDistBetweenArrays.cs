namespace DSA_C.Search
{
    public class FindDistBetweenArrays
    {
        public void Start()
        {
            int[] arr1 = {4,5,8}, arr2 = {10,9,1,8};
            int d = 2;
            Console.WriteLine(FindTheDistanceValue(arr1, arr2, d));

        }

        int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
            Array.Sort(arr2);
            int count = 0;
            foreach(int num in arr1)
            {
                if (CheckIfLessValueExist(num, arr2, d))
                    continue;
                count++;
            }
            return count;
        }

        bool CheckIfLessValueExist(int num, int[] arr, int d)
        {
            int l=0, r=arr.Length -1;
            while (l<=r)
            {
                int m = l+(r-l)/2;
                if (Math.Abs(num-arr[m]) <= d)
                    return true;
                if (num < arr[m])
                    r = m-1;
                else
                    l=m+1;
            }
            return false;
        }
    }
}