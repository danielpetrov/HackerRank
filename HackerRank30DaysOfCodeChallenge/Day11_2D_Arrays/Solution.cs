namespace Day11_2D_Arrays
{
    using System;

    internal class Solution
    {
        private static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int maxSum = -9 * 7;//constrains - value in cell = [-9 --- 9]
            int currentSum = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    currentSum = TraverseHourglassAndReturnSum(row, column, arr);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
            TraverseHourglassAndReturnSum(3, 2, arr);
        }
        
        private static int TraverseHourglassAndReturnSum(int row, int column, int[][] arr)
        {
           
            int sum = 0;

            sum += arr[row][column];
            sum += arr[row][column + 1];
            sum += arr[row][column + 2];
            sum += arr[row + 1][column + 1];
            sum += arr[row + 2][column];
            sum += arr[row + 2][column + 1];
            sum += arr[row + 2][column + 2];

            return sum;
        }
    }
}