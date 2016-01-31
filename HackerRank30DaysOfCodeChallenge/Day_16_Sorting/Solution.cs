namespace Day_16_sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            Console.ReadLine();

            List<int> a = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse).ToList();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.WriteLine(d.ToString());
        }
    }
}