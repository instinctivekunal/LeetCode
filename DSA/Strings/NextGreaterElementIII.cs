namespace DSA_C.Strings
{
    public class NextGreaterElementIII
    {
        public void Start()
        {
            int n = 21;
            Console.WriteLine(NextGreaterElement(n));
        }

         int NextGreaterElement(int n) 
        {
            char[] arr = n.ToString().ToCharArray();
            int i, j;
            // 1. Find first digit that is smallest next to it starting from right side.
            for (i=arr.Length-1; i>0; i--)
                if(arr[i]>arr[i-1])
                    break;
            // No such element. Edge case.
            if (i==0) return -1;
            
            // 2. Find smallest digit on right side of (i-1)th. Digit that is greater than arr[i-1]
            int no = arr[i-1], min = i;
            for (j=i+1; j<arr.Length; j++)
                if (arr[j] > no && arr[j] <= arr[min])
                    min = j;

            // 3. Swap it with the smalles digit with arr[i-1]
            char t = arr[i-1];
            arr[i-1] = arr[min];
            arr[min] = t;

            // 4. Sort the digits after i-1 position in ASC
            Array.Sort(arr,i,arr.Length-i);

            // Convert back to integer
            double val = Double.Parse(new string(arr));
            return (val <= int.MaxValue) ? (int)val : -1;
        }
    }
}