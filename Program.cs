using System;

namespace Primality
{
    class Program
    {
        public static string primality(int n)
        {
            if (n < 2) return "Not prime";
            else if (n == 2) return "Prime";
            else if (n % 2 == 0) return "Not prime";

            var sqrt = (int)Math.Sqrt(n);

            for (var i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                    return "Not prime";

            }

            return "Prime";
        }
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            for (int pItr = 0; pItr < p; pItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                string result = primality(n);

                Console.WriteLine(result);
            }
        }
    }
}
