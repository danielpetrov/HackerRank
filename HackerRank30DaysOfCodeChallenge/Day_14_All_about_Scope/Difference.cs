using System.Collections.Generic;
using System.Text;

namespace Day_14_All_about_Scope
{
    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] arrayOfElements)
        {
            this.elements = arrayOfElements;
            this.maximumDifference = 0;
        }

        public void computeDifference()
        {
            nextCombination(new int[2], 0, 0, this.elements.Length - 1);
        }

        private void nextCombination(int [] vector, int currentIndex, int start, int end)
        {
            if (currentIndex == vector.Length)
            {
                int currentSum = elements[vector[0]] - elements[vector[1]];
                if (currentSum < 0)
                {
                    currentSum = -currentSum;
                }

                if (currentSum > maximumDifference)
                {
                    maximumDifference = currentSum;
                }
                return;
            }

            for (int i = start; i <= end; i++)
            {
                vector[currentIndex] = i;
                nextCombination(vector, currentIndex + 1, i + 1, end);
            }
        }
    }
}