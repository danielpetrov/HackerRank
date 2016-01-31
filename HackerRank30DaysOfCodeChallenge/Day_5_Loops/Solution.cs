//a+20b,a+20b+21b,......,a+20b+21b+...+2N−1b
namespace Day_5_Loops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            Queue<int[]> inputLines = new Queue<int[]>();

            for (int i = 0; i < t; i++)
            {
                var vars = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse).ToArray();

                inputLines.Enqueue(vars);
            }

            while (inputLines.Count > 0)
            {
                Solve(inputLines.Dequeue());
                if (inputLines.Count != 0)
                {
                    Console.WriteLine();
                }
            }
        }

        private static void Solve(int[] vars)
        {
            int b = vars[1];

            for (int counterToN = 1; counterToN <= vars[2]; counterToN++)
            {
                int sum = vars[0];// a = vars[0], sum += a;

                for (int columnIndex = 0; columnIndex < counterToN; columnIndex++)// n = vars[2]
                {
                    sum += (int)Math.Pow(2, columnIndex) * b;
                }

                Console.Write(sum);
                if (counterToN != vars[2])
                {
                    Console.Write(" ");
                }
            }
        }
    }
}