namespace Day_20_Review_More_String_Methods
{
    using System;

    class Solution
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(new char[] { ' ', '!', '[', '?', '.', '\\', '_', '@', '+', ']', '\'', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(a.Length);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
