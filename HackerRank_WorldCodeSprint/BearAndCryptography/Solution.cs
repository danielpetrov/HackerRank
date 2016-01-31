namespace BearAndCryptography
{
    using System;
    using System.Text;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            //TODO : make function to find all divisors of number with O(n)
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t; i++)
            {
                string[] tokens_N = Console.ReadLine().Split(' ');
                double n = Convert.ToDouble(tokens_N[0]);
                int k = Convert.ToInt32(tokens_N[1]);
                double s = 0;

                switch (k)
                {
                    case 1:
                        sb.AppendLine("1");
                        break;

                    case 2:
                        s = solveForTwo(n);
                        sb.AppendLine(s.ToString());
                        break;

                    case 3:
                        s = solveForThree(n);
                        sb.AppendLine(s.ToString());
                        break;

                    default:
                        if (n < 15000)
                        {
                            s = solve(n, k);
                            sb.AppendLine(s.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }

        public static double solve(double n, int k)
        {
            double maxNumber = 0;

            for (double i = 3; i <= n; i++)
            {
                int counter = 0;

                for (double j = 1; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }

                if (counter == k)
                {
                    maxNumber = Math.Max(maxNumber, i);
                }
            }

            if (maxNumber > 0)
            {
                return maxNumber;
            }

            return -1;
        }

        private static double solveForThree(double n)
        {
            double answer = 0;

            for (double i = n; i >= 4; i--)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    if (CheckIfPrime(Math.Sqrt(i)))
                    {
                        answer = i;
                        break;
                    }
                }
            }

            return answer;
        }

        private static double solveForTwo(double n)
        {
            double answer = 0;

            for (double i = n; i >= 2; i--)
            {
                if (CheckIfPrime(i))
                    {
                        answer = i;
                        break;
                    }
            }

            return answer;
        }

        private static bool CheckIfPrime(double number)
        {
            bool isPrime = true;

            for (double j = 2; j < Math.Sqrt(number); j++)
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