namespace FizzBuzz
{
    internal static class FizzBuzz
    {
        public static IList<string> Solve(int n) 
        {
            IList<string> resultList = new List<string>();

            for (int i = 1; i <= n; i++) 
            {
                string result = string.Empty;
                if (i % 3 == 0) 
                {
                    result += "Fizz";
                }
                if (i % 5 == 0) 
                {
                    result += "Buzz";
                }

                resultList.Add(!string.IsNullOrEmpty(result) ? result : i.ToString());
            }

            return resultList;
        }
    }
}
