namespace FlatlandSpaceStations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            List<int> c = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int maxPath = 0;
            int minPath = 0;
            int maxStartingEndingPath = 0;
            c.Sort();

            maxPath = Math.Max(maxPath, c[0] - 0);
            maxPath = Math.Max(maxPath, (n - 1) - c[c.Count - 1]);
            maxStartingEndingPath = Math.Max(maxPath, c[0] - 0);

            for (int i = 0; i < c.Count - 1; i++)
            {
                maxPath = Math.Max(maxPath, c[i + 1] - c[i]);
            }
            if (true)
            {
            }

            if (m > 1)
            {
                if (maxStartingEndingPath == maxPath)
                {
                    minPath = maxPath;
                }
                else
                {
                    minPath = Convert.ToInt32(Math.Floor(Convert.ToDecimal(maxPath / 2)));
                }
            }
            else
            {
                minPath = maxPath;
            }
            Console.WriteLine(minPath);
        }
    }
}