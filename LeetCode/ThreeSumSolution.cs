using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LeetCode
{
    public class ThreeSumSolution
    {

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            var zeroCount = 0;
            var onceSet = new HashSet<int>();
            var twiceSet = new HashSet<int>();
            
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    zeroCount++;
                }

                if (onceSet.Contains(num) && num != 0)
                {
                    twiceSet.Add(num);
                }
                else
                {
                    onceSet.Add(num);
                }
            }

            if (zeroCount >= 3)
            {
                result.Add(new List<int>(){0, 0, 0});
            }

            foreach (var i in twiceSet)
            {
                var remainder = 0 - i - i;
                if (onceSet.Contains(remainder))
                {
                    result.Add(new List<int>(){i, i, remainder});
                }
            }

            var onceSetCopy = new HashSet<int>(onceSet);
            foreach (var i in onceSet)
            {
                if (i >= 0)
                {
                    break;
                }
                onceSetCopy.Remove(i);
                foreach (var j in onceSetCopy)
                {
                    var remainder = 0 - i - j;
                    if (remainder <= j)
                    {
                        break;
                    }
                    if (onceSetCopy.Contains(remainder))
                    {
                        result.Add(new List<int>(){i, j, remainder});
                    }
                }
            }
            
            return result;
        }
    }
}