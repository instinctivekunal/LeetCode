namespace DSA_C.Sort
{
    public class MinAbsDifference
    {
        public void Start()
        {
            int[] arr = {3,8,-10,23,19,-4,-14,27};
            Console.WriteLine(string.Join(",", MinimumAbsDifference(arr)));
        }

         IList<IList<int>> MinimumAbsDifference(int[] arr) 
        {
            Array.Sort(arr);
            IList<IList<int>> ans = new List<IList<int>>();
            int mindiff = int.MaxValue;
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i]-arr[i-1] < mindiff)
                {
                    mindiff = arr[i]-arr[i-1];
                    ans.Clear();
                    ans.Add(new List<int> {arr[i-1], arr[i]});
                }
                else if (arr[i]-arr[i-1] == mindiff)
                    ans.Add(new List<int> {arr[i-1], arr[i]});
            }
            return ans;
        }

         IList<IList<int>> MinimumAbsDifference1(int[] arr) 
        {
            Array.Sort(arr);
            IList<IList<int>> ans = new List<IList<int>>();
            int mindiff = int.MaxValue;
            for(int i=1; i<arr.Length; i++)
                mindiff = Math.Min(mindiff, arr[i]-arr[i-1]);
            for(int i=1; i<arr.Length; i++)
                if (arr[i]-arr[i-1] == mindiff)
                    ans.Add(new List<int> {arr[i-1], arr[i]});
            return ans;
        }
    }
}