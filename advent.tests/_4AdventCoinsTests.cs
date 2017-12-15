using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace advent.tests
{
    [TestFixture]
    class _4AdventCoinsTests
    {
        [TestCase("abcdef", 609043)]
        [TestCase("pqrstuv", 1048970)]
        public void TestAdventCoins(string secretKey, int expectedNumber)
        {
            var sut = new _4AdventCoins();
            Assert.AreEqual(expectedNumber, sut.GetHashNumber(secretKey, 5));
        }
    }
}
