namespace Day_28_Regex
{
    using System;
    using System.Text;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            string BRACKET_LEFT = "(";
            string BRACKET_RIGHT = ")";
            string CLOSED_LEFT = "[";
            string CLOSED_RIGHT = "]";

            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int bracketsLeft = (text.Length - text.Replace(BRACKET_LEFT, "").Length) / BRACKET_LEFT.Length;

                int bracketsRight = (text.Length - text.Replace(BRACKET_RIGHT, "").Length) / BRACKET_RIGHT.Length;

                int closedLeft = (text.Length - text.Replace(CLOSED_LEFT, "").Length) /
                    CLOSED_LEFT.Length;

                int closedRight = (text.Length - text.Replace(CLOSED_RIGHT, "").Length) / CLOSED_RIGHT.Length;

                if (bracketsLeft != bracketsRight || closedLeft != closedRight)
                {
                    sb.AppendLine("Invalid");
                }
                else
                {
                    sb.AppendLine("Valid");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}