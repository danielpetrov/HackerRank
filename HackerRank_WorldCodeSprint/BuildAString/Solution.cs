namespace BuildAString
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Solution
    {
        private static double minPrice;
        private static int addPrice;
        private static int copyPrice;
        private static int stringLenght;
        private static string str = "";
        private static string text = "";
        private static string value = "";

        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string[] tokens_N = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_N[0]);
                int a = Convert.ToInt32(tokens_N[1]);
                int b = Convert.ToInt32(tokens_N[2]);
                str = Console.ReadLine();

                stringLenght = n;
                addPrice = a;
                copyPrice = b;

                minPrice = a * n;

                solve();

                result.AppendLine(minPrice.ToString());
            }

            Console.WriteLine(result.ToString());
        }

        private static void solve()
        {
            dfs(0, 0);
        }
        private static void dfs(int index, double price)
        {
            if (price >= minPrice)
            {
                return;
            }
            if (index > stringLenght)
            {
                return;
            }
            if (index == stringLenght)
            {
                minPrice = Math.Min(price, minPrice);
            }

            //add
            if (addPrice + price < minPrice)
            {
                dfs(index + 1, price + addPrice);
            }

            //copy
            if (index >= 1 && copyPrice + price < minPrice)
            {
                for (int i = 1; i <= stringLenght - index; i++)
                {
                    value = str.Substring(index, i);
                    text = str.Substring(0, index);
                    Regex rgx = new Regex(value);
                    bool ismatch = rgx.IsMatch(text);
                    if (ismatch)
                    {
                        dfs(index + i, price + copyPrice);
                    }
                }
            }
        }
    }
}