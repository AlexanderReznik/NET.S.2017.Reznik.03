﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryOperations.NUnitTests
{
    public class MixingIntTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 0)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 15)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 17)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 17)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -16)]
        public int InsertionBits_PositiveTest(int first, int second, int i, int j)
        {
            return BinaryOperations.MixingInt.InsertionBits(first, second, i, j);
        }
        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 5, 31)]
        public void InsertionBits_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BinaryOperations.MixingInt.InsertionBits(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void InsertionBits_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => BinaryOperations.MixingInt.InsertionBits(first, second, startPosition, finishPosition));
        }

    }
}
