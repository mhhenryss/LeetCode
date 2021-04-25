using System;

//https://leetcode.com/problems/divide-two-integers/

namespace LeetCode
{
    public class DivideSolution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            var result = 0;
            var negDividend = GetNegative(dividend);
            var negDivisor = GetNegative(divisor);

            var remainder = negDividend;

            if (negDivisor == -1)
            {
                return IsPositive(dividend, divisor) ? Math.Abs(dividend) : negDividend;
            }
            else
            {
                while (remainder <= negDivisor)
                {
                    var count = GetCurrentCount(negDivisor, remainder);
                    result += count;
                    remainder -= count * negDivisor;
                }
            }

            return IsPositive(dividend, divisor) ? result : result * -1;
        }

        private static int GetNegative(int num)
        {
            var result = num < 0 ? num : ~num + 1;
            return result;
        }

        private static int GetCurrentCount(int tempDivisor, int tempDividend)
        {
            var count = 1;

            tempDivisor <<= 1;

            while (tempDivisor >= tempDividend && tempDivisor < 0)
            {
                tempDivisor <<= 1;
                count <<= 1;
            }

            return count;
        }

        private static bool IsPositive(int num1, int num2)
        {
            return (num1 > 0 && num2 > 0) || (num1 < 0 && num2 < 0);
        }

    }
}
