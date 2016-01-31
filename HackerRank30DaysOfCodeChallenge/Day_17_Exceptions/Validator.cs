using System;
namespace Day_17_Exceptions
{
    public static class Validator
    {
        public static void CheckIfNonNegative(int number, string message = null)
        {
            if (number < 0)
            {
                throw new ArgumentException(message);
            }
        }

    }
}
