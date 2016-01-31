namespace Day_8_Dictionaries_and_Maps
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> namesAndPhones = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                namesAndPhones[Console.ReadLine()] = int.Parse(Console.ReadLine());
            }

            string line = null;

            while ( (line = Console.ReadLine()) != null )
            {
                if ( namesAndPhones.ContainsKey(line) )
                {
                    Console.WriteLine( line + "=" + namesAndPhones[line] );
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}