using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryOperations;

namespace BinaryOperations.Tests
{
    [TestClass()]
    public class MixingIntTests
    {
        public TestContext TestContext { get; set;}
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("BinaryOperations.Tests\\Data.xml")]
        [TestMethod]
        public void InsertionBits_PositiveTest()
        {
            int f = Convert.ToInt32(TestContext.DataRow["first"]);
            int s = Convert.ToInt32(TestContext.DataRow["second"]);
            int i = Convert.ToInt32(TestContext.DataRow["i"]);
            int j = Convert.ToInt32(TestContext.DataRow["j"]);

            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            var actual = MixingInt.InsertionBits(f, s, i, j);

            Assert.AreEqual(expected, actual);

        }
    }
}
