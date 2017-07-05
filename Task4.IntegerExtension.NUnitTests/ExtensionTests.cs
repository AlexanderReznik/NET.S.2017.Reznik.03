using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.IntegerExtension.NUnitTests
{
    public class ExtensionTests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public long NextBiggerNumber_Number_NextBigger(long x)
        {
            int time;
            return Task4.IntegerExtension.Extension.NextBiggerNumber(x, out time);
        }
        [TestCase(-1)]
        [TestCase(0)]
        public void NextBiggerNumber_NotPositiveNumber_ArgumentException(long x)
        {
            int time;
            Assert.Throws<ArgumentException>(() => Task4.IntegerExtension.Extension.NextBiggerNumber(x, out time));
        }

        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        //[TestCase(10, ExpectedResult = -1)]
        //[TestCase(20, ExpectedResult = -1)]
        public long NextBiggerNumberLong_Number_NextBigger(long x)
        {
            int time;
            return Task4.IntegerExtension.Extension.NextBiggerNumberLong(x, out time);
        }
        [TestCase(-1)]
        [TestCase(0)]
        public void NextBiggerNumberLong_NotPositiveNumber_ArgumentException(long x)
        {
            int time;
            Assert.Throws<ArgumentException>(() => Task4.IntegerExtension.Extension.NextBiggerNumberLong(x, out time));
        }
    }
}
