using System;

namespace LeetCode
{
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height)
        {
            var result = 0;
            var l = 0;
            var r = height.Length - 1;

            while (r > l)
            {
                var curArea = (r - l) * Math.Min(height[l], height[r]);
                if (curArea > result)
                {
                    result = curArea;
                }

                if (height[l] >= height[r])
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return result;
        }
    }
}