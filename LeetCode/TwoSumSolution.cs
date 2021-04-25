using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var num = target - nums[i];
                if (dic.ContainsKey(num))
                {
                    return new int[] {dic[num], i};
                }

                dic.Add(nums[i], i);
            }

            return null;
        }
    }
}