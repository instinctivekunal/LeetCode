namespace DSA_C.Recursion
{
    public class NumOfSteps
    {
        public void Start()
        {
            // int n = 8;
            // Console.WriteLine(NumberOfSteps(n));
            int num1=10;
            int num2=10;
            Console.WriteLine(CountOperations(num1, num2));
        }
        
         int NumberOfSteps(int num) 
        {
            return CountSteps(num, 0);
        }

         int CountSteps(int num, int count) {            
            if (num == 0) return count;
            else if (num%2 == 0)
                return CountSteps(num/2, count+1);
            else
                return CountSteps(num-1, count+1);
        }

         int CountOperations(int num1, int num2) 
        {
            return CountOperation(num1, num2, 0);
        }

         int CountOperation(int num1, int num2, int count) 
        {
            if (num1 == 0 || num2 == 0) return count;
            if (num1 >= num2)  
                return CountOperation(num1-num2, num2, count+1);
            else
                return CountOperation(num1, num2-num1, count+1);
        }
    }
}