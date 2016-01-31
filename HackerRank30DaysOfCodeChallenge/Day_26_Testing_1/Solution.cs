namespace Day_26_Testing_1
{
    using System;
    using System.Linq;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            int fine = 0;

            var real = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            var expected = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //years
            if (real[2] > expected[2])
            {
                fine = 10000;
            }
            else if (real[2] == expected[2])
            {
                //months
                if (real[1] > expected[1])
                {
                    fine = (real[1] - expected[1]) * 500;
                }
                else if (real[1] == expected[1])
                {
                    //days
                    if (real[0] > expected[0])
                    {
                        fine = (real[0] - expected[0]) * 15;
                    }
                }
            }

            Console.WriteLine(fine);
        }
    }
}