namespace Day_17_Exceptions
{
    using System;

    internal class Calculator
    {
        public int power(int n, int p)
        {
            Validator.CheckIfNonNegative(n, "n and p should be non-negative");
            Validator.CheckIfNonNegative(p, "n and p should be non-negative");
            return Convert.ToInt32(Math.Pow(Convert.ToDouble(n), Convert.ToDouble(p)));
        }
    }
}