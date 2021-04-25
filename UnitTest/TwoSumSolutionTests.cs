using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class TwoSumSolutionTests
    {
        [TestCase(new int[]{2, 7, 11, 15}, 9, new int[]{0, 1})]
        public void TwoSumTest(int[] nums, int target, int[] result)
        {
            var actual = new TwoSumSolution().TwoSum(nums, target);
            Assert.AreEqual(actual, result);
        }
    }
}