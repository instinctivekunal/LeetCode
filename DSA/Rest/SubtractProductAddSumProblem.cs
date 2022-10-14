namespace DSA_C.Rest
{
    public class SubtractProductAddSumProblem
    {
        public void Start()
        {
            int n = 4421;
            Console.WriteLine(SubtractProductAndSum(n));
        }

        int SubtractProductAndSum(int n) {
            int sum=0, prd=1;
            while (n > 0)     
            {
                int l = n%10;
                sum += l;
                prd *= l;
                n = n/10;
            }
            return prd-sum;
        }
    }
}