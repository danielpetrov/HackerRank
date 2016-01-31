namespace Day_6_Lets_Review
{
    using System;
    using System.Text;

    public class Solution
    {
        //n = 6
        //     #
        //    ##
        //   ###
        //  ####
        // #####
        //######
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char draw = '#';
            int counterForBlank = n - 1;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < counterForBlank)
                    {
                        result.Append(' ');
                    }
                    else
                    {
                        result.Append(draw);
                    }
                }

                counterForBlank--;
                if (i < n - 1)
                {
                    result.AppendLine();
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}