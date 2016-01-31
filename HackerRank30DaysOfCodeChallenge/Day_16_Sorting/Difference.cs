namespace Day_16_sorting
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    internal class Difference
    {
        private List<int> elements;

        private string output;

        public Difference(List<int> arrayOfElements)
        {
            this.elements = arrayOfElements;
            this.elements.Sort();
        }

        public void computeDifference()
        {
            int minDifference = Math.Abs(elements[1] - elements[0]);
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < elements.Count; i++)
            {
                int currentDifference = Math.Abs(elements[i] - elements[i - 1]);
                if (currentDifference < minDifference)
                {
                    sb = new StringBuilder();
                    sb.Append(elements[i - 1] + " " + elements[i] + " ");
                    minDifference = Math.Min(currentDifference, minDifference);
                }
                else if (currentDifference == minDifference)
                {
                    sb.Append(elements[i - 1] + " " + elements[i] + " ");
                }
            }

            output = sb.ToString();
        }

        public override string ToString()
        {
            return output;
        }
    }
}