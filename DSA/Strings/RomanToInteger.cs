namespace DSA_C.Strings
{
    public class RomanToInteger
    {
        public void Start()
        {
            string s = "MCMXCIV";
            Console.WriteLine(RomanToInt(s));
        }

         int RomanToInt(string s) 
        {
            int sum=0;
            for(int i=0; i<s.Length-1; i++)
            {
                int val = RomanNumerals(s[i]);
                if (val < RomanNumerals(s[i+1]))
                    sum -= val;
                else
                    sum += val;
            }
            return sum += RomanNumerals(s[s.Length-1]);
        }

         int RomanNumerals(char c)
        {
            switch(c){
                case 'I' : return 1;
                case 'V' : return 5;
                case 'X' : return 10;
                case 'L' : return 50;
                case 'C' : return 100;
                case 'D' : return 500;
                case 'M' : return 1000;
            };  
            return 0;
        }
    }
}