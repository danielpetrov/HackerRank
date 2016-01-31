namespace Day_25_Running_Time_and_Complexity
{
    using System;

    internal class Solution
    {
        private static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string prime = CheckIfPrime(number) ? "Prime" : "Not prime";

                Console.WriteLine(prime);
            }
        }

        private static bool CheckIfPrime(int number)
        {
            bool isPrime = true;

            for (int j = 2; j < Math.Sqrt(number); j++)
            {
                if (number % j == 0)
                {
                    isPrime = false;
                }
            }

            if (number == 1 || number == 0)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}