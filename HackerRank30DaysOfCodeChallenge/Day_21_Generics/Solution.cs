using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21_Generics
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }

        private static void printArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
