
namespace RomanToInteger
{
    internal static class RomanToInteger
    {
        private static readonly Dictionary<char, int> pairs = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        
        public static int Convert(string s) 
        {
            int result = 0;
            char[] charArray = s.ToCharArray().Reverse().ToArray();
            int previousValue = 0;    

            foreach (char value in charArray) 
            {
                int currentValue = pairs[value];
                if (currentValue < previousValue)
                {
                    result -= currentValue;
                }
                else 
                {
                    result += currentValue;
                }
                previousValue = currentValue;
            }

            return result;
        }
    }
}
