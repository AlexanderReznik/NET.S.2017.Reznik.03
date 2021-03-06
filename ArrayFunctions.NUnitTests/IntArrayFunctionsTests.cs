﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunctions.NUnitTests
{
    public class IntArrayFunctionsTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4}, ExpectedResult = -1)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 10 }, ExpectedResult = -1)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, 5, int.MaxValue, int.MaxValue}, ExpectedResult = 2)]
        public int GetSumMedian_OKTest_Median(int[] array)
        {
            return ArrayFunctions.IntArrayFunctions.GetSumMedian(array);
        }
        [TestCase(null)]
        public void GetSumMedian_Null_ArgumentNullException(int[] x)
        {
            Assert.Throws<ArgumentNullException>(() => IntArrayFunctions.GetSumMedian(x));
        }
        [TestCase(new int[] { })]
        public void GetSumMedian_Empty_ArgumentException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => IntArrayFunctions.GetSumMedian(x));
        }
    }
}
