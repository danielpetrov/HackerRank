using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Recursion
{
    class Solution
    {
        static void Main(string[] args)
        {
            
            var xY = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(xY[0]);
            int y = int.Parse(xY[1]);

            int result;

            if(x == y)
            {
                result = x;
            } 
            else
            {
                result = gcd(Math.Max(x, y) - Math.Min(x, y), Math.Min(x, y));
            }
            Console.WriteLine(result);

        }

        static int gcd(int k, int m)
        {
            if (k == m)
            { 
                return m;
            }

            return gcd( Math.Max(k, m) - Math.Min(k, m), Math.Min(k, m) );
        }
    }
}
