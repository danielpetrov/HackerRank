namespace MarsExploration
{
    using System;

    class Solution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < input.Length; i+=3)
            {
                if (input[i] !=  'S')
                {
                    counter++;
                }
                if (input[i + 1] != 'O')
                {
                    counter++;
                }
                if (input[i + 2] != 'S')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
