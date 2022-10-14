namespace Search
{
    public class ReachANumber
    {
        public void Start()
        {
            int target = 3;
            Console.WriteLine(ReachNumber(target));
        }
        
         int ReachNumber(int target) 
        {
            int sum=0, jump=1;
            target=Math.Abs(target);            
            while(sum<target)
            {
                sum+=jump;
                jump++;
            }
            Console.WriteLine("S->{0}..{1}..{2}",sum, jump, target);
            if((sum-target)%2 ==0)
                return jump-1;
            else if((sum+jump-target)%2==0)
                return jump;
            else
                return jump+1;
        }
    }
}