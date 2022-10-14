namespace DSA_C.Sort
{
    public class SortRelativeArray
    {
        public void Start()
        {
            int[] arr1 = {28,6,22,8,44,17};
            int[] arr2 = {22,28,8,6};
            Console.WriteLine(string.Join(",",RelativeSortArray(arr1, arr2)));
        }

         int[] RelativeSortArray(int[] arr1, int[] arr2) 
        {
            //Setup Dictionary for distinct elements
            Dictionary<int,int> data = new Dictionary<int,int>();
            foreach(int e in arr2)
                data.Add(e, 0);

            int n = arr1.Length;
            int[] ans = new int[n];

            //Counting times each element is present in arr1
            foreach(int e in arr1)
            {
                if(data.ContainsKey(e))
                    data[e] = data[e]+1;
                else
                    ans[--n] = e;
            }

            //Perform final sort based on arr2
            int p=0;
            foreach(int num in arr2)
            {
                int cnt = data[num];
                for(int i=0; i<cnt; i++)
                    ans[p++] = num;
            }
            Array.Sort(ans,p,ans.Length-p);
            return ans;
        }
    }
}