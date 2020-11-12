using System;
using LeetCode;
using NUnit.Framework;

namespace UnitTest
{
    public class DivideSolutionTests
    {
        [TestCase(10, 3, 3)]
        [TestCase(7, -3, -2)]
        [TestCase(int.MinValue, -1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        [TestCase(1, 1, 1)]
        [TestCase(1100540749, -1090366779, -1)]
        public void Test(int dividend, int divisor, int expected)
        {  
            var result = new DivideSolution().Divide(dividend, divisor);
            Assert.AreEqual(expected, result);
        }

        //[Test]
        //public void Test2()
        //{
        //    var input = int.MaxValue;
        //    var result = 0;

        //    try
        //    {
        //        result = ~input;
        //    }
        //    catch (OverflowException)
        //    {
        //        result = 123;
        //    }
        //    catch (Exception e)
        //    {
        //        var test = e;
        //    }

        //    Assert.AreEqual(123, result);
        //}
    }
}