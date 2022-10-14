namespace DSA_C.Sort
{
    public class AvgSalMinMax
    {
        public void Start()
        {
            int[] nums = {3,4,5,2};
            Console.WriteLine(Average(nums));
        }

         double Average(int[] salary) 
        {
            Array.Sort(salary);
            double sum = 0;
            for(int i=1; i<salary.Length-1; i++)
                sum+=salary[i];
            return sum/(double)(salary.Length-2);
        }
    }
}