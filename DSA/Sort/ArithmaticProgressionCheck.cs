namespace DSA_C.Sort
{
    public class ArithmaticProgressionCheck
    {
        public void Start()
        {
            int[] arr = {3,5};
            Console.WriteLine(string.Join(",", CanMakeArithmeticProgression(arr)));
        }

         bool CanMakeArithmeticProgression(int[] arr) 
        {
            Array.Sort(arr);
            int diff = arr[1]-arr[0];
            for(int i=2; i<arr.Length; i++)
                if (arr[i]-arr[i-1] != diff) return false;
            return true;
        }
    }
}