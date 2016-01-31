namespace Day_10_Binary_Numbers
{
    using System;
    using System.Text;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder tempStringresult = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string tempString = String.Empty;
                while (number > 0)
                {
                    tempString += number % 2;
                    number = number / 2;
                }

                tempString = Reverse(tempString);

                tempStringresult.Append(tempString);

                if (i != n - 1)
                {
                    tempStringresult.AppendLine();
                }
            }

            Console.Write(tempStringresult.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}