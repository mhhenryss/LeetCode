using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class TempTest
    {
        [Test()]
        public void Test1()
        {
            var lengthOfLongestSubstring = new LongestSubstringWithoutRepeatingCharactersSolution().LengthOfLongestSubstring("abba");
        }
    }
}