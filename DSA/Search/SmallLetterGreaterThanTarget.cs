namespace Search
{
    public class SmallLetterGreaterThanTarget
    {
        public void Start()
        {
            char[] letters = {'c', 'f', 'g', 'm'};
            char target = 'c';
            Console.WriteLine(NextGreatestLetter(letters, target));
        }

         char NextGreatestLetter(char[] letters, char target) 
        {
            int start=0, end=letters.Length-1;
            int mid=0;
            while(start<=end)
            {
                mid = start + (end-start)/2;                
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (letters[mid] == target)
                    start = mid+1;
                else if (letters[mid] < target)
                    start = mid+1;
                else
                    end = mid-1;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return letters[start % letters.Length];
        }
    }
}